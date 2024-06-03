using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class RoomCategoryController : Controller
    {
        IRoomCategoryRepo rcrepo;
        IHotelRepo hrepo;

        public RoomCategoryController(IRoomCategoryRepo rcrepo,IHotelRepo hrepo)
        {
            this.rcrepo = rcrepo;
            this.hrepo = hrepo;
        }

        public IActionResult Index()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            return View(this.rcrepo.GetByID(HotelID));
        }

        [HttpGet]
        public IActionResult Create()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            return View();
        }

        [HttpPost]
        public IActionResult Create(RoomCategory rec)
        {
            if (ModelState.IsValid)
            {
                this.rcrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            var rec = this.rcrepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(RoomCategory rec)
        {
            if (ModelState.IsValid)
            {
                this.rcrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.rcrepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
