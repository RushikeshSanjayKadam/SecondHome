using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TaxTbl")]
    public class Tax
    {
        [Key]
        public Int64 TaxID { get; set; }
        public decimal TaxPercentage { get; set; }
        public string HSNSACNo { get; set; }
    }
}
