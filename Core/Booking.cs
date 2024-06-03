using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("BookingTbl")]
    public class Booking
    {
        [Key]
        public Int64 BookingID { get; set; }
        public DateTime BookingDate { get; set; }

        [ForeignKey("User")]
        public Int64 UserID { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Hotel")]
        public Int64 HotelID { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
