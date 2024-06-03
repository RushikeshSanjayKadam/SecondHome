using Microsoft.AspNetCore.Mvc;
using Repo.ViewModels;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class HotelHomeController : Controller
    {
        IHotelRepo hrepo;
        public HotelHomeController(IHotelRepo hrepo)
        {
            this.hrepo = hrepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("HotelID"));
                var res = this.hrepo.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult EditProfile()
        {
            Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("HotelID"));
            var rec = this.hrepo.GetById(cid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(HotelProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("HotelID"));
                var res = this.hrepo.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}
