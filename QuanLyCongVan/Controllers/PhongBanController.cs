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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PhongBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    phongbanRepo.Create(c);
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
            var phongban = phongbanRepo.GetById(id);
            return View(phongban);
        }

        [HttpPost]
        public ActionResult Edit(PhongBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    phongbanRepo.Update(c);
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
                phongbanRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]PhongBanTableGridRequest request)
        {
            return Json(phongbanRepo.GetAll(request));
        }
    }
}