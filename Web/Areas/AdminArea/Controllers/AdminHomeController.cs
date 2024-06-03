using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class AdminHomeController : Controller
    {
        IAdminRepo repo;
        public AdminHomeController(IAdminRepo trepo)
        {
            this.repo = trepo;
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
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
                var res = this.repo.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult EditProfile()
        {
            Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
            var rec = this.repo.GetById(cid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(AdminProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
                var res = this.repo.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
            }
            return RedirectToAction("Index");
        }
    }
}
