using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("RoomBedTbl")]
    public class RoomBed
    {
        [Key]
        public Int64 RoomBedID { get; set; }
        public string NoofBeds { get; set; }

        [ForeignKey("BedType")]
        public Int64 BedTypeID { get; set; }
        public virtual BedType BedType { get; set; }
    }
}
