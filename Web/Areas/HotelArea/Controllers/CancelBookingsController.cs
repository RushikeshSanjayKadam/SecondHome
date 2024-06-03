using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class CancelBookingsController : Controller
    {
        ICancelBookingRepo cbkrepo;
        public CancelBookingsController(ICancelBookingRepo cbkrepo)
        {
            this.cbkrepo = cbkrepo;
        }

        public IActionResult Index()
        {
            return View(cbkrepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create(Int64 id)
        {
            ViewBag.BookingID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(CancelBooking rec)
        {
            if (ModelState.IsValid)
            {
                cbkrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var rec = cbkrepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(CancelBooking rec)
        {
            if (ModelState.IsValid)
            {
                cbkrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            cbkrepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
