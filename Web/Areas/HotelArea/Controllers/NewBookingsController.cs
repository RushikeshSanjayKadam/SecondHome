using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class NewBookingsController : Controller
    {
        IBookingRepo bkrepo;
        IBuildingRepo brepo;
        ICheckInRepo crepo;
        IFloorRepo frepo;
        IHotelRepo hrepo;
        IRoomRepo rrepo;

        public NewBookingsController(IBookingRepo bkrepo,IBuildingRepo brepo,ICheckInRepo crepo, IFloorRepo frepo, IHotelRepo hrepo,IRoomRepo rrepo)
        {
            this.bkrepo = bkrepo;
            this.brepo = brepo;
            this.crepo = crepo;
            this.frepo = frepo;
            this.hrepo = hrepo;
            this.rrepo = rrepo;
        }

        public IActionResult Index()
        {
            return View(bkrepo.GetNewBookings());
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            var rec = bkrepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Booking rec)
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            if (ModelState.IsValid)
            {
                bkrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            bkrepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
