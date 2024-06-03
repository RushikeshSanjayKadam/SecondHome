using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class RoomPhotosController : Controller
    {
        IRoomPhotosRepo rprepo;
        IRoomRepo rrepo;

        public RoomPhotosController(IRoomPhotosRepo rprepo,IRoomRepo rrepo)
        {
            this.rprepo = rprepo;
            this.rrepo = rrepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewPhotos(Int64 RoomID)
        {

            if (RoomID == 0)
            {
                return RedirectToAction("Index");
            }
            var v = this.rrepo.GetAll().Where(p => p.RoomID == RoomID);
            return View(v.ToList());
        }
    }
}
