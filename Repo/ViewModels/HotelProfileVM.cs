using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class HotelProfileVM
    {
        [Required(ErrorMessage ="Hotel Name Required")]
        public string HotelName { get; set; }
        [Required(ErrorMessage ="Email ID Required")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Contact Person Name Required")]
        public string ContactPersonName { get; set; }
        [Required(ErrorMessage ="Contact No Required")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage ="Address Required")]
        public string Address { get; set; }


    }
}
