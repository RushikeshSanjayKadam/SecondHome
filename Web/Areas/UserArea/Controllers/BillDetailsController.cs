using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuth]
    public class BillDetailsController : Controller
    {
        IBookingRepo brepo;
        ICheckInRepo cirepo;
        ICheckOutRepo corepo;
        IInvoiceRepo irepo;
        public BillDetailsController(IBookingRepo brepo, ICheckInRepo cirepo, ICheckOutRepo corepo, IInvoiceRepo irepo)
        {
            this.brepo = brepo;
            this.cirepo = cirepo;
            this.corepo = corepo;
            this.irepo = irepo;
        }

        public IActionResult Index()
        {
            var id = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            return View(this.irepo.GetInvoices(id));
        }
    }
}
