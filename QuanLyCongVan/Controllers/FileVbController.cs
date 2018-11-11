using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;

namespace QuanLyCongVan.Controllers
{
    public class FileVbController : Controller
    {
        FileVbRepository filevbRepo = new FileVbRepository();
        public ActionResult Index()
        {
            var listFileVb = filevbRepo.GetAll();
            return View(listFileVb);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FileVb c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    filevbRepo.Create(c);
                    return RedirectToAction("index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(c);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var filevb = filevbRepo.GetById(id);
            return View(filevb);
        }

        [HttpPost]
        public ActionResult Edit(FileVb c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    filevbRepo.Update(c);
                    return RedirectToAction("index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(c);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                filevbRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
    }
}