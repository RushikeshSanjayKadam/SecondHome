using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuth]
    public class CheckInController : Controller
    {
        IBookingRepo brepo;
        ICheckInRepo cirepo;
        ICheckOutRepo corepo;
        IInvoiceRepo irepo;

        public CheckInController(IBookingRepo brepo, ICheckInRepo cirepo, ICheckOutRepo corepo, IInvoiceRepo irepo)
        {
            this.brepo = brepo;
            this.cirepo = cirepo;
            this.corepo = corepo;
            this.irepo = irepo;
        }

        public IActionResult Index()
        {
            var id = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            return View(this.cirepo.GetBookingCheckIns(id));
        }
    }
}
