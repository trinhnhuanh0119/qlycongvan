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
    public class PhongBanController : Controller
    {
        PhongBanRepository phongbanRepo = new PhongBanRepository();
        public ActionResult Index()
        {
            var listPhongBan = phongbanRepo.GetAll();
            return View(listPhongBan);
        }

        [HttpPost]
        public ActionResult Create([FromBody]PhongBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    phongbanRepo.Create(c);
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
            var phongban = phongbanRepo.GetById(id);
            return Json(phongban);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                phongbanRepo.Delete(id);
                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]PhongBanTableGridRequest request)
        {
            return Json(phongbanRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]PhongBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   phongbanRepo.Update(c);
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