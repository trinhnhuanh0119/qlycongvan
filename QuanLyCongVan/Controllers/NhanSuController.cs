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
    public class NhanSuController : Controller
    {
        NhanSuRepository nhansuRepo = new NhanSuRepository();
        public ActionResult Index()
        {
            var listNhanSu = nhansuRepo.GetAll();
            return View(listNhanSu);
        }

        [HttpPost]
        public ActionResult Create([FromBody]NhanSuInsert c)
        {
            try
            {
                NhanSu nhanSu = new NhanSu();
                nhanSu.Anh = c.Anh;
                nhanSu.Dem = c.Dem;
                nhanSu.DiaChiCq = c.DiaChiCq;
                nhanSu.DiaChiNr = c.DiaChiNr;
                nhanSu.DienThoai = c.DienThoai;
                nhanSu.GioiTinh = c.GioiTinh;
                nhanSu.Ho = c.Ho;
                nhanSu.Ten = c.Ten;
                nhanSu.TenVietTat = c.TenVietTat;
                nhanSu.MaNhanSu = c.MaNhanSu;
                nhanSu.MaPhong = c.MaPhong;
                if(!string.IsNullOrEmpty(c.NgaySinh))
                nhanSu.NgaySinh = DateTime.ParseExact(c.NgaySinh, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
                if(!string.IsNullOrEmpty(c.NgayVaoNganh))
                nhanSu.NgayVaoNganh = DateTime.ParseExact(c.NgayVaoNganh, "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture);
                nhansuRepo.Create(nhanSu);
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
            var nhansu = nhansuRepo.GetById(id);
            return Json(nhansu);
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
        [HttpPost]
        public JsonResult getAllSearch([FromBody]NhanSuTableGridRequest request)
        {
            return Json(nhansuRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]NhanSu c)
        {
                try
                {
                    if (ModelState.IsValid)
                    {
                        nhansuRepo.Update(c);
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
