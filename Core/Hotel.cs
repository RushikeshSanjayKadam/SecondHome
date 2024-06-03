using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("HotelTbl")]
    public class Hotel
    {
        [Key]
        public Int64 HotelID { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
        public string ContactPersonName { get; set; }
        public string WebSiteUrl { get; set; }
        public string LogoFilePath { get; set; }
        public bool IsGSTApplicable { get; set; }
        public string GSTINNo { get; set; }

        [ForeignKey("City")]
        public Int64 CityID { get; set; }
        public virtual City City { get; set; }
        public virtual List<RoomCategory> RoomCategories { get; set; }
    }
}
