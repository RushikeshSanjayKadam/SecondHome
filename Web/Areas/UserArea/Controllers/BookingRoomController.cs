using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModels;
using Web.CustFilter;

namespace Web.Controllers
{
    [Area("UserArea")]
    [UserAuth]
    public class BookingRoomController : Controller
    {
        IUserRepo urepo;
        IBookingRoomRepo brrepo;
        IBookingRepo brepo;
        IRoomRepo rrepo;
        IRoomCategoryRepo rcrepo;
        IHotelRepo hrepo;
        public BookingRoomController(IBookingRoomRepo brrepo, IBookingRepo brepo, IRoomRepo rrepo,IRoomCategoryRepo rcrepo, IUserRepo urepo, IHotelRepo hrepo)
        {
            this.urepo = urepo;
            this.brrepo = brrepo;
            this.brepo = brepo;
            this.rrepo = rrepo;
            this.rcrepo = rcrepo;
            this.hrepo = hrepo;
        }
        public IActionResult Index()
        {
            return View(this.brrepo.GetAll());
        }




        [HttpGet]
        public IActionResult Create()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            ViewBag.Rooms = new SelectList(this.rrepo.GetAll(),"RoomID","RoomNumber");
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(),"RoomCategoryID","RoomCategoryName");
            ViewBag.Hotels = new SelectList(this.hrepo.GetAll(),"HotelID","HotelName");

            return View();
        }
        [HttpPost]
        public IActionResult Create(BookingRoomVM rec)
        {

            TempData["Message"] = null;
            ViewBag.Rooms = new SelectList(this.rrepo.GetAll(), "RoomID", "RoomNumber" ,rec.RoomID);
            ViewBag.RoomCategories = new SelectList(this.rcrepo.GetAll(), "RoomCategoryID", "RoomCategoryName",rec.RoomCategoryID);
            ViewBag.Hotels = new SelectList(this.hrepo.GetAll(), "HotelID", "HotelName",rec.HotelID);
            if (ModelState.IsValid)
            {
                rec.UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));

                var res = brrepo.Add(rec);

                if (res.IsSuccess)
                {
                    TempData["Message"] = res.Message;
                    return RedirectToAction("BookingSuccess");
                }
                else
                {
                    ModelState.AddModelError("", res.Message);
                    return View(rec);
                }
            }

            return View(rec);
        }     
        


        public IActionResult BookingSuccess()
        {
            return View();
        }
        public IActionResult Delete(Int64 id)
        {
            this.brrepo.Delete(id);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult CheckAvailability()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckAvailability(List<int>dates)
        {
            if (dates != null && dates.Count > 0)
            {
                DateTime today = DateTime.Today;
                List<DateTime> selectedDates = new List<DateTime>();

                foreach (int offset in dates)
                {
                    selectedDates.Add(today.AddDays(offset));
                }
                return RedirectToAction("Create");
            }
            else
            {
                // Handle if no dates are selected
                return RedirectToAction("Index");
            }
        }

        public IActionResult GetRoomByRoomCategoriesJson(Int64 id)
        {
            var rec = this.brrepo.GetRoomsJson(id);
            return Json(rec.ToList());
        }

        public IActionResult GetRoomCategoryByHotelJson(Int64 id)
        {
            var rec = this.brrepo.GetRoomCategoryJson(id);
            return Json(rec.ToList());
        }
    }
}
