using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IHotelRepo
    {
        LoginResultVM LogIn(LoginVM rec);
        void LogOut();
        List<Hotel> GetAllByCategory(Int64 CityID);
        public List<HotelVM> GetHotel(long CityID, long RoomCategoryID);
        List<Hotel> GetAll();
        RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id);
        RepoResultVM EditProfile(HotelProfileVM rec, Int64 id);
        HotelProfileVM GetById(Int64 id);
        RepoResultVM SignUp(HotelRegisterVM rec);
    }
}
