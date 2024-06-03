using Microsoft.AspNetCore.Mvc;
using Repo.ViewModels;
using Repo;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class ManageUser : Controller
    {
        IUserRepo urepo;
        ICityRepo crepo;

        public ManageUser(IUserRepo urepo, ICityRepo crepo)
        {
            this.urepo = urepo;
            this.crepo = crepo;
        }

        [HttpGet]
        public IActionResult SignIn()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.urepo.LogIn(rec);
                if (res.IsSuccess)
                {
                    HttpContext.Session.SetString("UserID", res.LogInID.ToString());
                    HttpContext.Session.SetString("FullName", res.LogInName);
                    return RedirectToAction("Index", "UserHome", new { area = "UserArea" });
                }
                else
                {
                    ModelState.AddModelError("", res.ErrorMessage);
                    return View(rec);
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Cities = new SelectList(this.crepo.GetAll(),"CityID","CityName");
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserRegisterVM rec)
        {
            ViewBag.Cities = new SelectList(this.crepo.GetAll(), "CityID", "CityName");
            if (ModelState.IsValid)
            {
                var res = this.urepo.SignUp(rec);
                if (res.IsSuccess)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    ModelState.AddModelError("", res.Message);
                    return View(rec);
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}
