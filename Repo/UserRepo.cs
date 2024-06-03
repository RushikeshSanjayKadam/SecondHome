using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class UserRepo : IUserRepo
    {
        CompanyContext cc;
        public UserRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public RepoResultVM ChangePassword(ChangePasswordVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();

            var oldrec = this.cc.Users.Find(id);
            if (oldrec.Password == rec.OldPassword)
            {
                oldrec.Password = rec.NewPassword;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Password Changed Successfully!";
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid Old Password!";
            }

            return res;
        }

        public RepoResultVM EditProfile(UserProfileVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var oldrec = this.cc.Users.Find(id);
                oldrec.FirstName = rec.FirstName;
                oldrec.LastName = rec.LastName;
                oldrec.MobileNo  = rec.MobileNo;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Profile Updated!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }

            return res;
        }

        public UserProfileVM GetById(long id)
        {
            var rec = (from t in this.cc.Users
                       where t.UserID == id
                       select new UserProfileVM
                       {
                       }).FirstOrDefault();
            return rec;
        }

        public LoginResultVM LogIn(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec = this.cc.Users.SingleOrDefault(p => p.UserEmail == rec.EmailID && p.Password == rec.Password);
            if (urec != null)
            {
                res.IsSuccess = true;
                res.LogInID = urec.UserID;
                res.LogInName = urec.FullName;
            }
            else
            {
                res.IsSuccess = false;
                res.ErrorMessage = "Invalid EmailID or Password!";
            }
            return res;
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        public RepoResultVM SignUp(UserRegisterVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                User user = new User();
                user.FirstName = rec.FirstName;
                user.LastName = rec.LastName;
                user.UserEmail = rec.UserEmail;
                user.Password = rec.Password;
                user.CityID = rec.CityID;
                this.cc.Users.Add(user);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Sign Up Successful!";
            }
            catch(Exception ex)
            {
                res.IsSuccess= false;
                res.Message= ex.Message.ToString();
            }
            return res;
        }
    }
}
