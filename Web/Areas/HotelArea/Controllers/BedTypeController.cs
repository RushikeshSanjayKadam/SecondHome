using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class BedTypeController : Controller
    {
        IBedTypeRepo btrepo;
        IHotelRepo hrepo;

        public BedTypeController(IBedTypeRepo btrepo,IHotelRepo hrepo)
        {
            this.btrepo = btrepo;
            this.hrepo = hrepo;
        }

        public IActionResult Index()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            return View(this.btrepo.GetById(HotelID));
        }

        [HttpGet]
        public IActionResult Create()
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            return View();
        }

        [HttpPost]
        public IActionResult Create(BedType rec)
        {
            if (ModelState.IsValid)
            {
                this.btrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            Int32 HotelID = Convert.ToInt32(HttpContext.Session.GetString("HotelID"));
            ViewBag.HotelID = HotelID;
            var rec = this.btrepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(BedType rec)
        {
            if (ModelState.IsValid)
            {
                this.btrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.btrepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
