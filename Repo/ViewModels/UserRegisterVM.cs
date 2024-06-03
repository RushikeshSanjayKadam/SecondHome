using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class UserRegisterVM
    {
        [Required(ErrorMessage ="First Name Required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last Name Required!")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="EmailID Required!")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage ="Password Required!")]
        public string Password { get; set; }

        public Int64 CityID { get; set; }
        public string CityName { get; set; }
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
