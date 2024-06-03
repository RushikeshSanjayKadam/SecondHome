using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;

namespace Web.Controllers
{
    public class ManageAdmin : Controller
    {
        IAdminRepo arepo;

        public ManageAdmin(IAdminRepo arepo)
        {
            this.arepo = arepo;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(LoginVM rec)
        {
            if(ModelState.IsValid)
            {
                var res = this.arepo.LogIn(rec);
                if(res.IsSuccess)
                {
                    HttpContext.Session.SetString("AdminID", res.LogInID.ToString());
                    HttpContext.Session.SetString("FullName", res.LogInName);
                    return RedirectToAction("Index", "AdminHome", new {area="AdminArea"});
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
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
    }
}
