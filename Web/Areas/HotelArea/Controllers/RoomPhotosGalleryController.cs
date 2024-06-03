using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.HotelArea.Controllers
{
    [Area("HotelArea")]
    [HotelAuth]
    public class RoomPhotosGalleryController : Controller
    {
            IRoomPhotosRepo rprepo;
            IRoomRepo rrepo;
            IWebHostEnvironment env;

            public RoomPhotosGalleryController(IRoomPhotosRepo rprepo, IRoomRepo rrepo, IWebHostEnvironment env)
            {
                this.rprepo = rprepo;
                this.rrepo = rrepo;
                this.env = env;
            }

            public IActionResult Index()
            {
                return View(rprepo.GetAll());
            }

            [HttpGet]
            public IActionResult Create()
            {
                TempData["Message"] = null;
                ViewBag.Rooms = new SelectList(rrepo.GetAll(), "RoomID", "RoomNumber");
                return View();
            }
            [HttpPost]
            public IActionResult Create(RoomPhoto rec)
            {
                TempData["Message"] = null;
                ViewBag.Rooms = new SelectList(rrepo.GetAll(), "RoomID", "RoomNumber");
                if (ModelState.IsValid)
                {

                    if (rec.Photo == null)
                    {
                        ModelState.AddModelError("Photo", "Please Select File to Upload!");
                        return View(rec);
                    }

                    if (rec.Photo.Length <= 0)
                    {
                        ModelState.AddModelError("Photo", "Please Select File to Upload!");
                        return View(rec);
                    }

                    string relative = Path.Combine("RoomPhotos", rec.Photo.FileName);
                    string actualpath = Path.Combine(this.env.WebRootPath, relative);
                    FileStream fs = new FileStream(actualpath, FileMode.Create);
                    rec.Photo.CopyTo(fs);
                    rec.PhotoFilePath = "\\" + relative;
                    var res = this.rprepo.Add(rec);

                    if (res.IsSuccess)
                    {
                        TempData["Message"] = res.Message;
                        return RedirectToAction("Index");
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
            public IActionResult Edit(long id)
            {
                TempData["Message"] = null;

                var rec = rprepo.GetByID(id); 
                ViewBag.Rooms = new SelectList(rrepo.GetAll(), "RoomID", "RoomNumber",rec.RoomID);

                return View(rec);
            }
            [HttpPost]
            public IActionResult Edit(RoomPhoto rec)
            {
                TempData["Message"] = null;
                ViewBag.Rooms = new SelectList(rrepo.GetAll(), "RoomID", "RoomNumber", rec.RoomID);

                if (ModelState.IsValid)
                {
                    var res = rprepo.Update(rec);
                    if (res.IsSuccess)
                    {
                        TempData["Message"] = res.Message;
                        return RedirectToAction("Index");
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
            public IActionResult Delete(long id)
            {
                TempData["Message"] = null;
                var res = rprepo.Delete(id);
                TempData["Message"] = res.Message;
                return RedirectToAction("Index");

            }


        }
}
