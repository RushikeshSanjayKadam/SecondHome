using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class RoomDetailsVM
    {
        public Int64 HotelID { get; set; }
        public String HotelName { get; set; }
        public Int64 RoomID { get; set; }
        public Int64 RoomNumber { get; set; }
        public string RoomPhotos { get; set; }
        public Int64 RoomCharges { get; set; }
        public Int64 MaxNoofAdults { get; set; }
        public Int64 MaxnoofChilds { get; set; }
        public Int64 RoomCategoryID { get; set; }
        public String RoomCategoryName { get;set; }
        public Int64 BedTypeID { get; set; }
        public string BedTypeName { get; set; }

        public Int64 CityID { get; set; }
        public String CityName { get; set; }
        public Int64 StateID { get; set; }
        public String StateName { get; set; }
        public Int64 CountryID { get; set;}
        public String CountryName { get; set; }

    }
}
