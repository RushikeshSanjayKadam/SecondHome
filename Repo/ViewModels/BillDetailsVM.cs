using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class BillDetailsVM
    {
        public Int64 InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Int64 CheckOutID { get; set; }
        public Int64 BookingID { get; set; }
        public decimal InvoiceTaxPercentage { get; set; }
        public decimal InvoiceTaxAmount { get; set; }
        public decimal TotalAmount{ get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TaxPercentage { get; set; }
        public virtual BookingCheckOut BookingCheckOut { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
