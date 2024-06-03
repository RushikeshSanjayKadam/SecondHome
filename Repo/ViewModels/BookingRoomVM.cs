using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class BookingRoomVM
    {
        public Int64 BookingRoomID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Int64 UserID { get; set; }
        public string FullName { get; set; }
        public Int64 RoomID { get; set; }
        public string RoomNumber { get; set; }
        public Int64 RoomCategoryID { get; set; }
        public string RoomCategoryName { get; set; }
        public Int64 HotelID { get; set; }
        public string HotelName { get; set;}
        public virtual RoomCategory RoomCategory { get; set; }

    }
}
