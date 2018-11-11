using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;

namespace QuanLyCongVan.Controllers
{
    public class NguoiDungController : Controller
    {
        NguoiDungRepository nguoidungRepo = new NguoiDungRepository();
        public ActionResult Index()
        {
            var listCategory = nguoidungRepo.GetAll();
            return View(listCategory);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NguoiDung c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nguoidungRepo.Create(c);
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
            var category = nguoidungRepo.GetById(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(NguoiDung c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nguoidungRepo.Update(c);
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
                nguoidungRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
    }
}