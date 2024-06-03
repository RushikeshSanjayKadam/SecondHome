using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class FloorController : Controller
    {
        IFloorRepo frepo;
        IBuildingRepo brepo;
        IHotelRepo hrepo;

        public FloorController(IFloorRepo frepo,IBuildingRepo brepo, IHotelRepo hrepo)
        {
            this.frepo = frepo;
            this.brepo = brepo;
            this.hrepo = hrepo;
        }

        public IActionResult Index()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            return View(this.frepo.GetById(HotelID));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Buildings = new SelectList(this.brepo.GetAll(), "BuildingID", "BuildingName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Floor rec)
        {
            if (ModelState.IsValid)
            {
                this.frepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.Buildings = new SelectList(this.brepo.GetAll(), "BuildingID", "BuildingName");
            var rec = this.frepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Floor rec)
        {
            if (ModelState.IsValid)
            {
                this.frepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.frepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
