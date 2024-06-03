using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class LoginResultVM
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public Int64 LogInID { get; set; }
        public string LogInName { get; set; }
    }
}
