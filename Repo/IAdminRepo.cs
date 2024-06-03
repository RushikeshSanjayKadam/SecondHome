using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IAdminRepo
    {
        LoginResultVM LogIn(LoginVM rec);

        void LogOut();

        RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id);

        RepoResultVM EditProfile(AdminProfileVM rec, Int64 id);

        AdminProfileVM GetById(Int64 id);
    }
}
