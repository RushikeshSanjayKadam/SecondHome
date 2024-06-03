using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IBookingRoomRepo : IGenRepo<BookingRoom>
    {
        List<BookingRoom> GetAll();
        BookingRoom GetByID(Int64 id);
        RepoResultVM Add(BookingRoomVM rec);
        RepoResultVM Delete(Int64 id);
        List<BookingRoom> GetAllBooked();
        List<RoomsVM> GetRoomsJson(long RoomCategoryID);
        List<RoomCategoryVM> GetRoomCategoryJson(long HotelID);
        List<RoomCategory> GetHotelID(Int64 id);
        HotelRoomVM FindID(Int64 roomID, string roomNumber);
    }
}
