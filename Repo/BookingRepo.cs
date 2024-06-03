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
    public class BookingRepo : GenRepo<Booking>, IBookingRepo
    {
        CompanyContext cc;

        public BookingRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public RepoResultVM Add(Booking rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.Bookings.Add(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Booking Successfully!";
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
                var rec = this.cc.Bookings.Find(id);
                this.cc.Bookings.Remove(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Booking Deleted!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }


        public List<Booking> GetAll()
        {
            return this.cc.Bookings.ToList();
        }


        public Booking GetByID(long id)
        {
            return this.cc.Bookings.Find(id);
        }

        public List<Booking> GetNewBookings()
        {
            var v = from t in this.cc.Bookings
                    where !(from t1 in this.cc.BookingsCheckIn 
                            select t1.BookingID ).Contains(t.BookingID) &&
                    !(from t1 in this.cc.CancelBooking select t1.BookingID).Contains(t.BookingID)
                            select t;
            return v.ToList();
        }

        public List<Booking> GetBookings(Int64 id)
        {
            var v = from t in this.cc.Bookings
                    where (from t1 in this.cc.Users
                           select t1.UserID).Contains(id)
                           && t.UserID==id
                    select t;
            return v.ToList();
        }

        public RepoResultVM Update(Booking rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Booking Updated!";
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
