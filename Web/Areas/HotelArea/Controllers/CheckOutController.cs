using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class CheckOutController : Controller
    {
        IBookingRepo bkrepo;
        ICheckOutRepo corepo;
        public CheckOutController(ICheckOutRepo corepo, IBookingRepo bkrepo)
        {
            this.corepo = corepo;
            this.bkrepo = bkrepo;
        }

        public IActionResult Index()
        {
            return View(corepo.GetCheckOuts());
        }

        [HttpGet]
        public IActionResult Create(Int64 id)
        {
            var bid = id;
            ViewBag.BookingID = bid;
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookingCheckOut rec)
        {
            if (ModelState.IsValid)
            {
                corepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var rec = corepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(BookingCheckOut rec)
        {
            if (ModelState.IsValid)
            {
                corepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            corepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
