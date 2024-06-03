using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class RoomCategoryVM
    {
        public Int64 RoomCategoryID { get; set; }
        public string RoomCategoryName { get; set; }
        public Int64 HotelID { get; set; }
        public string HotelName { get; set;}
    }
}
