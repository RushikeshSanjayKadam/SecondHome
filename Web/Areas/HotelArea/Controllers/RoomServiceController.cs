using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class RoomServiceController : Controller
    {
        IRoomServiceRepo rsrepo;
        IRoomCategoryRepo rcrepo;
        IHotelRepo hrepo;

        public RoomServiceController(IRoomServiceRepo rsrepo,IRoomCategoryRepo rcrepo,IHotelRepo hrepo)
        {
            this.rsrepo = rsrepo;
            this.rcrepo = rcrepo;
            this.hrepo = hrepo;
        }

        public IActionResult Index()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            return View(this.rsrepo.GetById(HotelID));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(), "RoomCategoryID", "RoomCategoryName");
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            return View();
        }

        [HttpPost]
        public IActionResult Create(RoomService rec)
        {
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(), "RoomCategoryID", "RoomCategoryName");
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            if (ModelState.IsValid)
            {
                this.rsrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(), "RoomCategoryID", "RoomCategoryName");
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            var rec = this.rsrepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(RoomService rec)
        {
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(), "RoomCategoryID", "RoomCategoryName");
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            if (ModelState.IsValid)
            {
                this.rsrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.rsrepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
