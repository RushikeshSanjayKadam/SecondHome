using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CancelBookingTbl")]
    public class CancelBooking
    {
        [Key]
        public Int64 CancelBookingID { get; set; }
        public DateTime CancelBookingDate { get; set; }
        public string ReasonToCancel {get; set; }
        public bool IsAdvance {  get; set; }

        [ForeignKey("Booking")]
        public Int64 BookingID { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
