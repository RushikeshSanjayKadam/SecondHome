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
    public class CheckOutRepo : GenRepo<BookingCheckOut>, ICheckOutRepo
    {
        CompanyContext cc;

        public CheckOutRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
        public RepoResultVM Add(BookingCheckOut rec, Int64 rid)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                rec.BookingCheckOutDate = DateTime.Now;
                Booking sm = this.cc.Bookings.Find(rid);

                this.cc.BookingsCheckOut.Add(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Check Out Successfully!";
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
                var rec = this.cc.BookingsCheckOut.Find(id);
                this.cc.BookingsCheckOut.Remove(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Check Out Deleted!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }


        public List<BookingCheckOut> GetAll()
        {
            return this.cc.BookingsCheckOut.ToList();
        }



        public BookingCheckOut GetByID(long id)
        {
            return this.cc.BookingsCheckOut.Find(id);
        }

        public List<BookingCheckOut> GetCheckOuts()
        {
            var v = from t in this.cc.BookingsCheckOut
                    where !(from t1 in this.cc.Invoices
                            select t1.CheckOutID)
                            .Contains(t.BookingCheckOutID)
                            &&
                            !(from t1 in this.cc.Invoices
                              select t1.BookingCheckOut.BookingID).Contains(t.BookingID)
                    select t;
            return v.ToList();
        }

        public List<BookingCheckOut> GetCheckOutsfromCheckIns(Int64 id)
        {
                var v = from t in this.cc.BookingsCheckOut
                        where (from t1 in this.cc.Users
                               select t1.UserID).Contains(id)
                               && t.Booking.UserID == id
                        select t;
                return v.ToList();
        }

        public RepoResultVM Update(BookingCheckOut rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Check Out Updated!";
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
