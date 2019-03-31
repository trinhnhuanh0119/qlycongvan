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
                nhanSu.DiaChiCq = c.diaChiCq;
                nhanSu.DiaChiNr = c.diaChiNr;
                nhanSu.DienThoai = c.dienThoai;
                if (c.gioiTinh != null)
                {
                    nhanSu.GioiTinh = Convert.ToBoolean(c.gioiTinh);
                }

                nhanSu.Ten = c.ten;
                nhanSu.MaNhanSu = c.maNhanSu;
                nhanSu.MaPhong = c.maPhong;
                if (!string.IsNullOrEmpty(c.ngaySinh))
                    nhanSu.NgaySinh = Convert.ToDateTime(c.ngaySinh);
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

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                nhansuRepo.Delete(id);
                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }
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

        [HttpGet]
        public ActionResult GetDropDowns() {
            return Json(nhansuRepo.GetDropDowns());
        }


    }
}