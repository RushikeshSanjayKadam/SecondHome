using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModels;

namespace Web.ViewComponents
{
    public class RoomsVC:ViewComponent
    {
        IRoomCategoryRepo rcrepo;
        IHotelRepo hrepo;
        ICityRepo crepo;
        IStateRepo srepo;
        ICountryRepo ccrepo;

        public RoomsVC(IRoomCategoryRepo rcrepo,IHotelRepo hrepo, ICityRepo crepo, IStateRepo srepo, ICountryRepo ccrepo)
        {
            this.rcrepo = rcrepo;
            this.hrepo = hrepo;
            this.crepo = crepo;
            this.srepo = srepo;
            this.ccrepo = ccrepo;
        }

        [HttpGet]
        public IViewComponentResult Invoke(Int64 rcid)
        {
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(),"RoomCategoryID","RoomCategoryName");
            ViewBag.Cities = new SelectList(this.crepo.GetAll(),"CityID","CityName");
            ViewBag.States = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            ViewBag.Countries = new SelectList(this.ccrepo.GetAll(), "CountryID", "CountryName");
            return View();
        }

    }
}
