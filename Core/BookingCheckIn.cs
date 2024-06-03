using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("BookingCheckInTbl")]
    public class BookingCheckIn
    {
        [Key]
        public Int64 BookingCheckInID { get; set; }
        public DateTime BookingCheckInDate { get; set; }
        public string NoofAdults { get; set; }
        public string  NoofChilds { get; set; }
        public string PersonName { get; set; }
        public string IsAddressProofFilePath { get; set; }
        public Int64 DocumentType {  get; set; }

        [ForeignKey("Booking")]
        public Int64 BookingID { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
