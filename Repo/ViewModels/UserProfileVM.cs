using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class UserProfileVM
    {
        [Required(ErrorMessage ="First Name Required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last Name Required!")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Mobile Number Required!")]
        public string MobileNo { get; set; }
    }
}
