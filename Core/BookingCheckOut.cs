using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("BookingCheckOutTbl")]
    public class BookingCheckOut
    {
        [Key]
        public Int64 BookingCheckOutID { get; set; }
        public DateTime BookingCheckOutDate { get; set; }

        [ForeignKey("Booking")]
        public Int64 BookingID { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
