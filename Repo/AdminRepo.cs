using Infra;
using Repo.ViewModels;

namespace Repo
{
    public class AdminRepo : IAdminRepo
    {
        CompanyContext cc;

        public AdminRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id)
        {
            RepoResultVM res = new RepoResultVM();

            var oldrec = this.cc.Admins.Find(id);
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

        public RepoResultVM EditProfile(AdminProfileVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var oldrec = this.cc.Admins.Find(id);
                oldrec.FirstName = rec.FirstName;
                oldrec.LastName = rec.LastName;
                oldrec.EmailID = rec.EmailID;
                oldrec.MobileNo = rec.MobileNo;
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

        public AdminProfileVM GetById(long id)
        {
            var rec = (from t in this.cc.Admins
                       where t.AdminID == id
                       select new AdminProfileVM
                       {
                       }).FirstOrDefault();
            return rec;
        }


        public LoginResultVM LogIn(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec = this.cc.Admins.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
            if(urec!= null)
            {
                res.IsSuccess = true;
                res.LogInID = urec.AdminID;
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
    }
}
