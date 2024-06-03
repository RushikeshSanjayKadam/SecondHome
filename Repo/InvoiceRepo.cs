using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class InvoiceRepo : GenRepo<Invoice>, IInvoiceRepo
    {
        CompanyContext cc;
        public InvoiceRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
        public RepoResultVM Add(BillDetailsVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                Invoice ic = new Invoice();
                ic.CheckOutID = rec.CheckOutID;
                ic.BookingCheckOut.BookingID = rec.BookingCheckOut.BookingID;
                ic.InvoiceDate = DateTime.Now;
                ic.TotalAmount = rec.TotalAmount;
                ic.DiscountAmount = rec.DiscountAmount;
                ic.TaxAmount = rec.TaxAmount;
                ic.TaxPercentage = rec.TaxPercentage;

                this.cc.Invoices.Add(ic);
                this.cc.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Paid Successfully!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }

        public RepoResultVM Delete(long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var rec = this.cc.Invoices.Find(id);
                this.cc.Invoices.Remove(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Payment Deleted!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }


        public List<Invoice> GetAll()
        {
            return this.cc.Invoices.ToList();
        }

        public Invoice GetByID(long id)
        {

            return this.cc.Invoices.Find(id);
        }

        public List<Invoice> GetInvoices(long id)
        {
            var v = from t in this.cc.Invoices
                    where (from t1 in this.cc.Users
                           select t1.UserID).Contains(id)
                           && t.BookingCheckOut.Booking.UserID == id
                    select t;
            return v.ToList();
        }

        public RepoResultVM Update(Invoice rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Payment Updated!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }

            return res;
        }
    }
}
