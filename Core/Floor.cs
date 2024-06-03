using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("FloorTbl")]
    public class Floor
    {
        [Key]
        public Int64 FloorID { get; set; }
        public string FloorNumber { get; set; }

        [ForeignKey("Building")]
        public Int64 BuildingID { get; set; }
        public virtual Building Building { get; set; }
    }
}
