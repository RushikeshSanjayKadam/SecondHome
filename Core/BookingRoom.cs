using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("BookinRoomTbl")]
    public class BookingRoom
    {
        [Key]
        public Int64 BookingRoomID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        [ForeignKey("User")]
        public Int64 UserID { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Room")]
        public Int64 RoomID { get; set; }
        public virtual Room Room { get; set; }

    }
}
