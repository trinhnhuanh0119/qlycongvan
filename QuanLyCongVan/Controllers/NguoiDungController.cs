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
    public class NguoiDungController : Controller
    {
        NguoiDungRepository nguoidungRepo = new NguoiDungRepository();
        NhanSuRepository nhanSuRepository = new NhanSuRepository();
        public ActionResult Index()
        {
            var listNguoiDung = nguoidungRepo.GetAll();
            return View(listNguoiDung);
        }

        [HttpPost]
        public ActionResult Create([FromBody]NguoiDungInsert c)
        {
            try
            {

                NguoiDung nguoiDung = new NguoiDung();
                nguoiDung.TenTaiKhoan = c.tenTaiKhoan;
                nguoiDung.MatKhau = c.matKhau;
                if(c.kichHoat != null)
                {
                    nguoiDung.KichHoat = Convert.ToBoolean(c.kichHoat);
                }
                nguoiDung.MaNhanSu = c.maNhanSu;
                nguoidungRepo.Create(nguoiDung);
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
            var nguoidung = nguoidungRepo.GetById(id);
            return Json(nguoidung);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                nguoidungRepo.Delete(id);
                return Json(true);
            }
            catch (Exception )
            {
                return Json(false);
            }
        }

        [HttpPost]
        public JsonResult getAllSearch([FromBody]NguoiDungTableGridRequest request)
        {
            return Json(nguoidungRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]NguoiDung c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nguoidungRepo.Update(c);
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
        public ActionResult DropNS()
        {
            return Json(nhanSuRepository.GetDropDowns());
        }
    }
}

