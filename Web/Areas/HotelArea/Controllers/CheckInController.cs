using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class CheckInController : Controller
    {
        ICheckInRepo cirepo;
        IBookingRepo bkrepo;
        IBookingRoomRepo brrepo;
        IRoomRepo rrepo;
        public CheckInController(ICheckInRepo cirepo,IBookingRepo bkrepo, IBookingRoomRepo brrepo, IRoomRepo rrepo)
        {
            this.cirepo = cirepo;
            this.bkrepo = bkrepo;
            this.brrepo = brrepo;
            this.rrepo = rrepo;
        }

        public IActionResult Index()
        {
            return View(this.cirepo.GetCheckIns());
        }
        [HttpGet]
        public IActionResult Create(Int64 id)
        {
            var bid =id;
            ViewBag.BookingID = bid;
            return View();
        }
        [HttpPost]
        public IActionResult Create(BookingCheckIn rec)
        {
            TempData["Message"] = null;
            if (ModelState.IsValid)
            {

                var res = this.cirepo.Add(rec);

                if (res.IsSuccess)
                {
                    TempData["Message"] = res.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", res.Message);
                    return View(rec);
                }
            }
            return View(rec);
        }

        public IActionResult Delete(Int64 id)
        {
            this.cirepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
