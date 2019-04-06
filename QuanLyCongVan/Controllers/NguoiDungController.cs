using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Cells;
using Microsoft.AspNetCore.Hosting;
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
        private IHostingEnvironment _env;
        public NguoiDungController(IHostingEnvironment env)
        {
            _env = env;
        }
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

        [HttpPost]
        public ActionResult ExportExcel()
        {
            try
            {
                var webRoot = _env.WebRootPath;
                DataTable dt = new DataTable();
                QuanLyCongVanContext db = new QuanLyCongVanContext();
                var paht = System.IO.Path.Combine(webRoot, "Content/TempExcel/NguoiDung.xlsx");
                Workbook wb = new Workbook();

                //Cell Cells = char.Parse(new Cell["A3"].ToString());
                Worksheet ws = wb.Worksheets[0];
                dt.Columns.Add("Tên tài khoản");
                dt.Columns.Add("Mật khẩu");
                dt.Columns.Add("kích hoạt");
                dt.Columns.Add("Mã nhân sự");
                List<NguoiDung> listnd = new List<NguoiDung>();
                listnd = db.NguoiDung.ToList();
                string listnds = "";
                if (listnd.Count > 0)
                {
                    listnds = String.Join(",", listnd.Select(x => x.ToString()).ToArray());
                }
                var ob = new NguoiDungRepository();
                var data = ob.GetAll();
                foreach (NguoiDung item in data)
                {
                    dt.Rows.Add(item.TenTaiKhoan, item.MatKhau, item.KichHoat, item.MaNhanSu);
                }
                string filename = "DanhSachNguoiDung" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xlsx";
                string folderName = "/assets/Excel/";

                var file = System.IO.Path.Combine(webRoot + folderName + filename);
                if (!System.IO.Directory.Exists(folderName))
                {
                    System.IO.Directory.CreateDirectory(folderName);
                }
                ws.Cells.ImportDataTable(dt, false, 2, 0);
                wb.Save(file);
                return Json(folderName + filename);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

