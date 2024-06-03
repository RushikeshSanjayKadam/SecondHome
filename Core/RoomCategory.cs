using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("RoomCategoryTbl")]
    public class RoomCategory
    {
        [Key]
        public Int64 RoomCategoryID { get; set; }
        public string RoomCategoryName { get; set; }
        public decimal BaseCharges { get; set; }

        [ForeignKey("Hotel")]
        public Int64 HotelID { get; set; }
        public virtual Hotel Hotel { get; set; }

        public virtual List<Room> Rooms { get; set; }
    }
}
