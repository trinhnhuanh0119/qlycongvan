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
    public class VanBanController : Controller
    {
        VanBanRepository vanbanRepo = new VanBanRepository();
        public ActionResult Index()
        {
            var listVanBan = vanbanRepo.GetAll();
            return View(listVanBan);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(VanBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vanbanRepo.Create(c);
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
            var vanban = vanbanRepo.GetById(id);
            return View(vanban);
        }

        [HttpPost]
        public ActionResult Edit(VanBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vanbanRepo.Update(c);
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
                vanbanRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]VanBanTableGridRequest request)
        {
            return Json(vanbanRepo.GetAll(request));
        }
    }
}