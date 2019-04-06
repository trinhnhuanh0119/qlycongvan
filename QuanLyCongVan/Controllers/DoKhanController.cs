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

        [HttpPost]
        public ActionResult Create([FromBody]DoKhan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dokhanRepo.Create(c);
                    return Json(c);
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
            return Json(dokhan);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                dokhanRepo.Delete(id);
                return Json(true);
            }
            catch (Exception )
            {
                return Json(false);
            }
        }

        [HttpPost]
        public JsonResult getAllSearch([FromBody]DoKhanTableGridRequest request)
        { 
            return Json(dokhanRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]DoKhan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dokhanRepo.Update(c);
                    return Json(c);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(c);
        }
    }
}