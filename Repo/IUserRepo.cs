using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IUserRepo
    {
        LoginResultVM LogIn(LoginVM rec);
        void LogOut();
        RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id);
        RepoResultVM EditProfile(UserProfileVM rec, Int64 id);
        UserProfileVM GetById(Int64 id);
        RepoResultVM SignUp(UserRegisterVM rec);
    }
}
