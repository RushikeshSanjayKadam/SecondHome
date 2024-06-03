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
    public class HotelRepo:IHotelRepo
    {
        CompanyContext cc;

        public HotelRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id)
        {
            RepoResultVM res = new RepoResultVM();

            var oldrec = this.cc.Hotels.Find(id);
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

        public RepoResultVM EditProfile(HotelProfileVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var oldrec = this.cc.Hotels.Find(id);
                oldrec.HotelName = rec.HotelName;
                oldrec.EmailID = rec.EmailID;
                oldrec.ContactPersonName = rec.ContactPersonName;
                oldrec.ContactNo = rec.ContactNo;
                oldrec.Address = rec.Address;
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

        public List<HotelVM> GetHotel(long CityID, long RoomCategoryID)
        {
            var res = from t in this.cc.Cities
                      join t1 in this.cc.Hotels
                      on t.CityID equals t1.CityID
                      join t2 in this.cc.RoomCategories
                      on t1.CityID equals t2.RoomCategoryID
                      join t3 in this.cc.Rooms
                      on t2.HotelID equals t3.RoomID
                      select new HotelVM
                      {
                          CityID = t.CityID,
                          CityName = t.CityName,
                          HotelID = t1.HotelID,
                          HotelName = t1.HotelName,
                          Address = t1.Address,
                          RoomCategoryID = t2.RoomCategoryID,
                          RoomCategoryName = t2.RoomCategoryName,
                          RoomID = t3.RoomID,
                          RoomName = t3.RoomNumber,
                      };
            return res.ToList();
        }

        public List<Hotel> GetAll()
        {
            return this.cc.Hotels.ToList();
        }

        public HotelProfileVM GetById(long id)
        {
            var rec = (from t in this.cc.Hotels
                       where t.HotelID == id
                       select new HotelProfileVM
                       {
                       }).FirstOrDefault();
            return rec;
        }


        public LoginResultVM LogIn(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec = this.cc.Hotels.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
            if (urec != null)
            {
                res.IsSuccess = true;
                res.LogInID = urec.HotelID;
                res.LogInName = urec.HotelName;
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

        public RepoResultVM SignUp(HotelRegisterVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                Hotel hotel = new Hotel();
                hotel.HotelName = rec.HotelName;
                hotel.EmailID = rec.EmailID;
                hotel.Password = rec.Password;
                hotel.CityID = rec.CityID;
                this.cc.Hotels.Add(hotel);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Sign Up Successful!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }

        public List<Hotel> GetAllByCategory(long CityID)
        {
            return this.cc.Hotels.Where(p => p.CityID == CityID).ToList();
        }
    }
}
