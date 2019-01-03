using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;
using QuanLyCongVan.Repository.Object;

namespace QuanLyCongVan.Controllers
{
    public class ChucVuController : Controller
    {
        ChucVuRepository chucvuRepo = new ChucVuRepository();
        public ActionResult Index()
        {
            var listChucVu = chucvuRepo.GetAll();
            return View(listChucVu);
        }
        [HttpPost]
        public ActionResult Create([FromBody]ChucVu c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    chucvuRepo.Create(c);
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
            var chucvu = chucvuRepo.GetById(id);
            return Json(chucvu);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                chucvuRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }

        [HttpPost]
        public JsonResult getAllSearch([FromBody]ChucVuTableGridRequest request)
        {
            return Json(chucvuRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]ChucVu c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    chucvuRepo.Update(c);
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