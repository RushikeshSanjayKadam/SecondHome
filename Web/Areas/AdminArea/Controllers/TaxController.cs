﻿using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class TaxController : Controller
    {
        ITaxRepo trepo;
        public TaxController(ITaxRepo trepo)
        {
            this.trepo = trepo;
        }

        public IActionResult Index()
        {
            return View(this.trepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tax rec)
        {
            if (ModelState.IsValid)
            {
                this.trepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.trepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Tax rec)
        {
            if (ModelState.IsValid)
            {
                this.trepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.trepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
