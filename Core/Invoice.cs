using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        public Int64 InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TaxPercentage { get; set; }

        [ForeignKey("BookingCheckOut")]
        public Int64 CheckOutID { get; set; }
        public virtual BookingCheckOut BookingCheckOut { get; set; }

    }
}
