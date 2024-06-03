using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("RoomServiceTbl")]
    public class RoomService 
    {
        [Key]
        public Int64 RoomServiceID { get; set; }
        public string RoomServiceName { get; set; }
        public decimal RoomServicePrice { get; set; }

        [ForeignKey("RoomCategory")]
        public Int64 RoomCategoryID { get; set; }
        public virtual RoomCategory RoomCategory { get; set; }

        [ForeignKey("Hotel")]
        public Int64 HotelID { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
