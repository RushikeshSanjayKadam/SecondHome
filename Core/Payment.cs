using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("PaymentTbl")]
    public class Payment
    {
        [Key]
        public Int64 PaymentID { get; set; }
        public int PaymentMethod {  get; set; }
        public decimal Amount { get; set; }
        public bool IsAdvance {  get; set; }

        [ForeignKey("Booking")]
        public Int64 BookingID { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
