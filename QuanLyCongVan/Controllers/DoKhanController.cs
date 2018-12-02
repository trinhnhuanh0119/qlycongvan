using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;
using QuanLyCongVan.Repository.Object;
using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Controllers
{
    
    public class DoKhanController : Controller
    {
        private DoKhanRepository dokhanRepo = new DoKhanRepository();
        public ActionResult Index()
        {
            IEnumerable<DoKhan> listDoKhan = dokhanRepo.GetAll();
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
            DoKhan dokhan = dokhanRepo.GetById(id);
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

        [HttpPost]
        public JsonResult getAllSearch([FromBody]DoKhanTableGridRequest request)
        { 
            return Json(dokhanRepo.GetAll(request));
        }
    }
}