using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("RoomPhototTbl")]
    public class RoomPhoto
    {
        [Key]
        public Int64 RoomPhotoID { get; set; }
        public string PhotoTitle { get; set; }
        public string PhotoFilePath { get; set; }
        public DateTime UploadDate { get; set; }
        [NotMapped]
        public IFormFile Photo {  get; set; }

        [ForeignKey("Room")]
        public Int64 RoomID { get; set; }
        public virtual Room Room { get; set; }
    }
}
