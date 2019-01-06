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
    public class NguoiDungController : Controller
    {
        NguoiDungRepository nguoidungRepo = new NguoiDungRepository();
        public ActionResult Index()
        {
            var listNguoiDung = nguoidungRepo.GetAll();
            return View(listNguoiDung);
        }

        [HttpPost]
        public ActionResult Create([FromBody]NguoiDung c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nguoidungRepo.Create(c);
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
            var nguoidung = nguoidungRepo.GetById(id);
            return Json(nguoidung);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                nguoidungRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]NguoiDungTableGridRequest request)
        {
            return Json(nguoidungRepo.GetAll(request));
        }
        [HttpPost]
        public ActionResult Update([FromBody]NguoiDung c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nguoidungRepo.Update(c);
                    return View(c);
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
