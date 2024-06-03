using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class RoomController : Controller
    {
        IRoomRepo rrepo;
        IFloorRepo frepo;
        IRoomCategoryRepo rcrepo;

        public RoomController(IRoomRepo rrepo,IFloorRepo frepo,IRoomCategoryRepo rcrepo)
        {
            this.rrepo = rrepo;
            this.frepo = frepo;
            this.rcrepo = rcrepo;
        }

        public IActionResult Index()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            return View(this.rrepo.GetById(HotelID));
        }

        [HttpGet]
        public IActionResult Create()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(),"RoomCategoryID","RoomCategoryName");
            ViewBag.Floors = new SelectList(this.frepo.GetAll(),"FloorID","FloorNumber");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Room rec)
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(), "RoomCategoryID", "RoomCategoryName");
            ViewBag.Floors = new SelectList(this.frepo.GetAll(), "FloorID", "FloorNumber");
            if (ModelState.IsValid)
            {

                this.rrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(), "RoomCategoryID", "RoomCategoryName");
            ViewBag.Floors = new SelectList(this.frepo.GetAll(), "FloorID", "FloorNumber");
            var rec = this.rrepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Room rec)
        {
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(), "RoomCategoryID", "RoomCategoryName");
            ViewBag.Floors = new SelectList(this.frepo.GetAll(), "FloorID", "FloorNumber");
            if (ModelState.IsValid)
            {
                this.rrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.rrepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
