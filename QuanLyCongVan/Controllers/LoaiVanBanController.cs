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
    public class LoaiVanBanController : Controller
    {
        LoaiVanBanRepository loaivanbanRepo = new LoaiVanBanRepository();
        public ActionResult Index()
        {
            var listLoaiVanBan = loaivanbanRepo.GetAll();
            return View(listLoaiVanBan);
        }

        [HttpPost]
        public ActionResult Create([FromBody]LoaiVanBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    loaivanbanRepo.Create(c);
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
            var loaivanban = loaivanbanRepo.GetById(id);
            return Json(loaivanban);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                loaivanbanRepo.Delete(id);
                return Json(true);
            }
            catch (Exception )
            {
                return Json(false);
            }
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]LoaiVanBanTableGridRequest request)
        {
            return Json(loaivanbanRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]LoaiVanBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    loaivanbanRepo.Update(c);
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