using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;

namespace QuanLyCongVan.Controllers
{
    public class NhanSuController : Controller
    {
        NhanSuRepository nhansuRepo = new NhanSuRepository();
        public ActionResult Index()
        {
            var listNhanSu = nhansuRepo.GetAll();
            return View(listNhanSu);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NhanSu c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nhansuRepo.Create(c);
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
            var nhansu = nhansuRepo.GetById(id);
            return View(nhansu);
        }

        [HttpPost]
        public ActionResult Edit(NhanSu c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nhansuRepo.Update(c);
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
                nhansuRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
    }
}