using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("BedType")]
    public class BedType
    {
        [Key]
        public Int64 BedTypeID { get; set; }
        public string BedTypeName { get; set; }

        [ForeignKey("Hotel")]
        public Int64 HotelID { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
