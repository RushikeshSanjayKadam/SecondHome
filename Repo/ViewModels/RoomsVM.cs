using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class RoomsVM
    {
        public Int64 RoomID { get; set; }
        public string RoomNumber { get; set; }
        public Int64 RoomCategoryID { get; set; }
        public string RoomCategoryName { get; set; }
    }
}
