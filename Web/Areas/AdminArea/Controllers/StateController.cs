using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class StateController : Controller
    {
        IStateRepo repo;
        ICountryRepo crepo;
        public StateController(IStateRepo repo, ICountryRepo crepo)
        {
            this.repo = repo;
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(State rec)
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                this.repo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.repo.GetById(id);
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(State rec)
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                this.repo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.repo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
