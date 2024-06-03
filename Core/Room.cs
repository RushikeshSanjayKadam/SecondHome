using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("RoomTbl")]
    public class Room
    {
        [Key]
        public Int64 RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomPhotos { get; set; }
        public decimal RoomCharges { get; set; }
        public string MaxNoofAdults { get; set; }
        public string MaxNoofChilds { get; set; }

        [ForeignKey("RoomCategory")]
        public Int64 RoomCategoryID { get; set; }
        public virtual RoomCategory RoomCategory { get; set; }

        [ForeignKey("Floor")]
        public Int64 FloorID { get; set; }
        public virtual Floor Floor { get; set; }

        public Room()
        {
            RoomCategory = new RoomCategory();
        }
    }
}
