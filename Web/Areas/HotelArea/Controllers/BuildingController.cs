using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class BuildingController : Controller
    {
        IBuildingRepo brepo;
        IHotelRepo hrepo;

        public BuildingController(IBuildingRepo brepo,IHotelRepo hrepo)
        {
            this.brepo = brepo;
            this.hrepo = hrepo;
        }

        public IActionResult Index()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            return View(this.brepo.GetById(HotelID));
        }

        [HttpGet]
        public IActionResult Create()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Building rec)
        {
            if (ModelState.IsValid)
            {
                this.brepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            var rec = this.brepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Building rec)
        {
            if (ModelState.IsValid)
            {
                this.brepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.brepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
