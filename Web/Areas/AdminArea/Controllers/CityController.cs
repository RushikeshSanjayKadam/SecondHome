using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class CityController : Controller
    {
        ICityRepo repo;
        IStateRepo srepo;
        ICountryRepo crepo;
        public CityController(ICityRepo repo, IStateRepo srepo,ICountryRepo crepo)
        {
            this.repo = repo;
            this.srepo = srepo;
            this.crepo = crepo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(),"CountryID","CountryName");
            ViewBag.States = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(City rec)
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            ViewBag.States = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
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
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName",rec.CountryID);
            ViewBag.States = new SelectList(this.srepo.GetAll(), "StateID", "StateName",rec.StateID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(City rec)
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName",rec.CountryID);
            ViewBag.States = new SelectList(this.srepo.GetAll(), "StateID", "StateName",rec.StateID);
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

        public IActionResult GetStatesJson(Int64 id)
        {
            var rec = this.srepo.GetStateByCountryID(id);
            return Json(rec.ToList());
        }

        public IActionResult GetCitiesJson(Int64 id)
        {
            var rec = this.repo.GetCityByStateID(id);
            return Json(rec.ToList());
        }

    }
}
