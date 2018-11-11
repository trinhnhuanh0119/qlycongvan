using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;

namespace QuanLyCongVan.Controllers
{
    public class LoaiVanBanController : Controller
    {
        LoaiVanBanRepository loaivanbanRepo = new LoaiVanBanRepository();
        public ActionResult Index()
        {
            var listLoaiVanBan = loaivanbanRepo.GetAll();
            return View(listLoaiVanBan);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(LoaiVanBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    loaivanbanRepo.Create(c);
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
            var loaivanban = loaivanbanRepo.GetById(id);
            return View(loaivanban);
        }

        [HttpPost]
        public ActionResult Edit(LoaiVanBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    loaivanbanRepo.Update(c);
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
                loaivanbanRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
    }
}