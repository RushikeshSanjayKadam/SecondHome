using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class BillDetailsController : Controller
    {
        IInvoiceRepo irrepo;
        IBookingRepo brepo;
        ICheckOutRepo corepo;
        public BillDetailsController(IInvoiceRepo irrepo, IBookingRepo brepo, ICheckOutRepo corepo)
        {
            this.irrepo = irrepo;
            this.brepo = brepo;
            this.corepo = corepo;
        }

        public IActionResult Index()
        {
            var v = this.irrepo.GetAll();
            return View(v);
        }
        [HttpGet]
        public IActionResult Create(Int64 id)
        {

            ViewBag.CheckOutID = id;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Invoice rec)
        {
            if(ModelState.IsValid)
            {
                this.irrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }


        public IActionResult Delete(Int64 id)
        {
            this.irrepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
