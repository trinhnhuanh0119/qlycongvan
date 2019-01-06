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

        [HttpPost]
        public ActionResult Create([FromBody]VanBanInsert c)
        {
            try
            {
                VanBan vanBan = new VanBan();
                vanBan.VbdiDen = c.VbdiDen;
                vanBan.MaLoaiVb = c.MaLoaiVb;
                vanBan.MaCqbh = c.MaCqbh;
                vanBan.DoKhan = c.DoKhan;
                vanBan.DoMat = c.DoMat;
                vanBan.SoDen = c.SoDen;
                vanBan.SoVb = c.SoVb;
                vanBan.TrichYeu = c.TrichYeu;
                vanBan.NoiNhan = c.NoiNhan;
                vanBan.NguoiKy = c.NguoiKy;
                vanBan.FileDinhKem = c.FileDinhKem;
                vanBan.KetQuaXuLy = c.KetQuaXuLy;
                if (!string.IsNullOrEmpty(c.NgayDen))
                    vanBan.NgayDen= DateTime.ParseExact(c.NgayDen, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
                if (!string.IsNullOrEmpty(c.NgayKy))
                    vanBan.NgayKy = DateTime.ParseExact(c.NgayKy, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
                if (!string.IsNullOrEmpty(c.HanXuLy))
                    vanBan.HanXuLy = DateTime.ParseExact(c.HanXuLy, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
                vanbanRepo.Create(vanBan);
                    return Json(c);
                
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
            return Json(vanban);
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

        [HttpPost]
        public ActionResult Update([FromBody]VanBan c)
        {
            try
            {
                vanbanRepo.Update(c);
                return Json(c);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(c);
        }
    }
}