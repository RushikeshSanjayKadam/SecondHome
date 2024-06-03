using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("InvoiceTaxTbl")]
    public class InvoiceTax
    {
        [Key]
        public Int64 InvoiceTaxID { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TaxAmount { get; set; }

        [ForeignKey("Invoice")]
        public Int64 InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
