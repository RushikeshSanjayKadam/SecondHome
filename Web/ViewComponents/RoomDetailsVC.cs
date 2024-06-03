using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;

namespace Web.ViewComponents
{
    public class RoomDetailsVC:ViewComponent
    {
        IBedTypeRepo btrepo;
        IHotelRepo hrepo;
        IRoomCategoryRepo rcrepo;

        public RoomDetailsVC(IBedTypeRepo btrepo, IHotelRepo hrepo, IRoomCategoryRepo rcrepo)
        {
            this.btrepo = btrepo;
            this.hrepo = hrepo;
            this.rcrepo = rcrepo;
        }

        public IViewComponentResult Invoke(Int64 rcid)
        {
            ViewBag.BedTypes = new SelectList(this.btrepo.GetAll(),"BedTypeID","BedTypeName");

            return View(this.hrepo.GetAll());
        }
    }
}
