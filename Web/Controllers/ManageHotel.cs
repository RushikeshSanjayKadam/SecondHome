using Microsoft.AspNetCore.Mvc;
using Repo.ViewModels;
using Repo;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class ManageHotel : Controller
    {
        IHotelRepo hrepo;
        ICityRepo crepo;

        public ManageHotel(IHotelRepo hrepo, ICityRepo crepo)
        {
            this.hrepo = hrepo;
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
                var res = this.hrepo.LogIn(rec);
                if (res.IsSuccess)
                {
                    HttpContext.Session.SetString("HotelID", res.LogInID.ToString());
                    HttpContext.Session.SetString("HotelName", res.LogInName);
                    return RedirectToAction("Index", "HotelHome", new { area = "HotelArea" });
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
            ViewBag.Cities = new SelectList(this.crepo.GetAll(), "CityID", "CityName");
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(HotelRegisterVM rec)
        {
            ViewBag.Cities = new SelectList(this.crepo.GetAll(), "CityID", "CityName");
            if (ModelState.IsValid)
            {
                var res = this.hrepo.SignUp(rec);
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
