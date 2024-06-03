using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using System.Linq;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IHotelRepo hrepo;
        IRoomCategoryRepo rcrepo;
        IRoomRepo rrepo;
        ICityRepo crepo;
        IStateRepo srepo;

        public HomeController(IHotelRepo hrepo, IRoomCategoryRepo rcrepo, IRoomRepo rrepo, ICityRepo crepo, IStateRepo srepo)
        {
            this.hrepo = hrepo;
            this.rcrepo = rcrepo;
            this.rrepo = rrepo;
            this.crepo = crepo;
            this.srepo = srepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStatesJson(Int64 id)
        {
            var rec = this.srepo.GetStateByCountryID(id);
            return Json(rec.ToList());
        }

        public IActionResult GetCitiesJson(Int64 id)
        {
            var rec = this.crepo.GetCityByStateID(id);
            return Json(rec.ToList());
        }

        public IActionResult SearchByName(Int64 id)
        {
            ViewBag.RoomCategories = this.hrepo.GetAllByCategory(id);
            var v = ViewBag.RoomCategories;
            return View(v);
        }

        public IActionResult Details(Int64 id)
        {
            var rec = this.hrepo.GetById(id);
            return View(rec);
        }


    }
}
