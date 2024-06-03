    using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuth]
    public class UserHomeController : Controller
    {
        IUserRepo urepo;

        public UserHomeController(IUserRepo urepo)
        {
            this.urepo = urepo;
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
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.urepo.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult EditProfile()
        {
            Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var rec = this.urepo.GetById(cid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(UserProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.urepo.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}
