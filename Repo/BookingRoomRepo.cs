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
    public class BookingRoomRepo :GenRepo<BookingRoom>, IBookingRoomRepo
    {
        CompanyContext cc;

        public BookingRoomRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public RepoResultVM Add(BookingRoomVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                Booking b = new Booking();
                BookingRoom br = new BookingRoom();
                b.UserID = rec.UserID;
                br.UserID = rec.UserID;
                br.BookingRoomID = rec.BookingRoomID;
                br.RoomID = rec.RoomID;
                br.FromDate = rec.FromDate;
                br.ToDate = rec.ToDate;
                b.HotelID = rec.HotelID;
                this.cc.BookingsRooms.Add(br);
                this.cc.SaveChanges();

                b.BookingDate = DateTime.Now;
                this.cc.Bookings.Add(b);
                this.cc.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Room Booking Successfully!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }


        public List<BookingRoom> GetAll()
        {
            return this.cc.BookingsRooms.ToList();
        }

        public BookingRoom GetByID(long id)
        {
            return this.cc.BookingsRooms.Find(id);
        }
        public RepoResultVM Delete(long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var rec = this.cc.BookingsRooms.Find(id);
                this.cc.BookingsRooms.Remove(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Booking Room Deleted!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }
        public List<BookingRoom> GetAllBooked()
        {

            var booked = from t in this.cc.BookingsRooms
                         where !(from t1 in this.cc.BookingsCheckIn
                                 select t1.BookingID).Contains(t.BookingRoomID)
                         select t;
            return booked.ToList();
        }

        public List<RoomsVM> GetRoomsJson(long id)
        {
            var v = from t in this.cc.Rooms
                    where t.RoomCategoryID == id
                    select new RoomsVM
                    {
                        RoomID = t.RoomID,
                        RoomNumber = t.RoomNumber,
                    };
            return v.ToList();
        }

        public List<RoomCategory> GetHotelID(long id)
        {
            var v = from t1 in this.cc.RoomCategories
                    join t2 in this.cc.Hotels
                    on t1.HotelID equals t2.HotelID
                    select t1;
            return v.ToList();
        }

        public List<RoomCategoryVM> GetRoomCategoryJson(long id)
        {
            var v = from t in this.cc.RoomCategories
                    where t.HotelID == id
                    select new RoomCategoryVM
                    {
                        RoomCategoryID = t.RoomCategoryID,
                        RoomCategoryName = t.RoomCategoryName,
                    };
            return v.ToList();
        }

        public HotelRoomVM FindID(long roomID, string roomNumber)
        {
            Room rooms = this.cc.Rooms.Where(x => x.RoomID == roomID && x.RoomNumber == roomNumber).FirstOrDefault();
            Hotel hotels = this.cc.Hotels.Where(x => x.HotelID == rooms.RoomCategory.HotelID).FirstOrDefault();
            HotelRoomVM obj = new HotelRoomVM();
            obj.Room = rooms;
            obj.Hotel = hotels;
            return obj;
        }
    }
}
