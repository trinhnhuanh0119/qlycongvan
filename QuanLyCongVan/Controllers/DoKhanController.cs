using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;

namespace QuanLyCongVan.Controllers
{
    public class DoKhanController : Controller
    {
        DoKhanRepository dokhanRepo = new DoKhanRepository();
        public ActionResult Index()
        {
            var listDoKhan = dokhanRepo.GetAll();
            return View(listDoKhan);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DoKhan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dokhanRepo.Create(c);
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
            var dokhan = dokhanRepo.GetById(id);
            return View(dokhan);
        }

        [HttpPost]
        public ActionResult Edit(DoKhan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dokhanRepo.Update(c);
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
                dokhanRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
    }
}