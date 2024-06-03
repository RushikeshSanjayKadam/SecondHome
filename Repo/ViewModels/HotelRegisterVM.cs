using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class HotelRegisterVM
    {
        [Required(ErrorMessage = "Hotel Name Required")]
        public string HotelName { get; set; }
        [Required(ErrorMessage = "Email ID Required")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Password Required!")]
        public string Password { get; set; }
        public Int64 CityID { get; set; }
        public string CityName { get; set; }
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }

    }
}
