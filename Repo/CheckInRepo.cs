using Core;
using Infra;
using Microsoft.AspNetCore.Http;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class CheckInRepo : GenRepo<BookingCheckIn>, ICheckInRepo
    {
        CompanyContext cc;

        public CheckInRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public RepoResultVM Add(BookingCheckIn rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                BookingCheckIn bc = new BookingCheckIn();
                bc.BookingID = rec.BookingID;
                bc.BookingCheckInDate = DateTime.Now;
                bc.PersonName = rec.PersonName;
                //bc.IsAddressProofFilePath = rec.IsAddressProofFilePath;
                bc.NoofAdults = rec.NoofAdults;
                bc.NoofChilds = rec.NoofChilds;

                this.cc.BookingsCheckIn.Add(bc);
                this.cc.SaveChanges();

                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Check In  Successfully!";
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
                var rec = this.cc.BookingsCheckIn.Find(id);
                this.cc.BookingsCheckIn.Remove(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Check In Deleted!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }


        public List<BookingCheckIn> GetAll()
        {
            return this.cc.BookingsCheckIn.ToList();
        }



        public BookingCheckIn GetByID(long id)
        {
            var rec = from t in this.cc.BookingsCheckIn
                      join t1 in this.cc.BookingsRooms
                      on t.BookingCheckInID equals t1.BookingRoomID
                      join t2 in this.cc.Rooms
                      on t.BookingCheckInID equals t2.RoomID
                      select new BookingCheckIn{
                          PersonName = t.PersonName,
                          IsAddressProofFilePath = t.IsAddressProofFilePath,
                          BookingID = t.BookingID,
                          NoofAdults = t.NoofAdults,
                          NoofChilds = t.NoofChilds,
                      };
            var result= rec.SingleOrDefault();
            return result;
        }

        public List<BookingCheckIn> GetCheckIns()
        {
            var v = from t in this.cc.BookingsCheckIn
                    where !(from t1 in this.cc.BookingsCheckOut
                            select t1.BookingID)
                            .Contains(t.BookingID)
                    select t;
            return v.ToList();
        }

        public List<BookingCheckIn> GetBookingCheckIns(Int64 id)
        {
            var v = from t in this.cc.BookingsCheckIn
                    where (from t1 in this.cc.Users
                           select t1.UserID).Contains(id)
                           && t.Booking.UserID == id
                    select t;
            return v.ToList();
        }
        public RepoResultVM Update(BookingCheckIn rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Check In Updated!";
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
