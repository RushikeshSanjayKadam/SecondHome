using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="EmailID Required!")]
        [EmailAddress(ErrorMessage ="Invalid EmailID!")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Password Required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
