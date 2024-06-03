using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class HotelVM
    {
        public Int64 CityID { get; set; }
        public string CityName { get; set; }
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }
        public Int64 HotelID { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public Int64 RoomCategoryID { get; set; }
        public string RoomCategoryName { get; set; }
        public int? RoomCount { get; set; }
        public Int64 RoomID { get; set; }
        public string RoomName { get; set; }
    }
}
