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
    public class NhanSuController : Controller
    {
        NhanSuRepository nhansuRepo = new NhanSuRepository();
        private IHostingEnvironment _env;
        public NhanSuController(IHostingEnvironment env)
        {
            _env = env;
        }

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
                nhanSu.DiaChiCQ = c.diaChiCq;
                nhanSu.DiaChiNR = c.diaChiNr;
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

        [HttpPost]
        public ActionResult ExportExcel()
        {
            try
            {
                var webRoot = _env.WebRootPath;
                DataTable dt = new DataTable();
                QuanLyCongVanContext db = new QuanLyCongVanContext();
                var paht = System.IO.Path.Combine(webRoot, "Content/TempExcel/NhanSu.xlsx");
                Workbook wb = new Workbook();

                //Cell Cells = char.Parse(new Cell["A3"].ToString());
                Worksheet ws = wb.Worksheets[0];
                dt.Columns.Add("Mã nhân sự");
                dt.Columns.Add("Tên");
                dt.Columns.Add("Giới tính");
                dt.Columns.Add("ngày sinh");
                dt.Columns.Add("Địa chỉ nhà");
                dt.Columns.Add("Địa chỉ cơ quan");
                dt.Columns.Add("Điện  thoại");
                dt.Columns.Add("Mã phòng");
                List<NhanSu> listns = new List<NhanSu>();
                listns = db.NhanSu.ToList();
                string listnss = "";
                if (listns.Count > 0)
                {
                    listnss = String.Join(",", listns.Select(x => x.ToString()).ToArray());
                }
                var ob = new NhanSuRepository();
                var data = ob.GetAll();
                foreach (NhanSu item in data)
                {
                    dt.Rows.Add(item.MaNhanSu, item.Ten, item.GioiTinh,Convert.ToDateTime(item.NgaySinh), item.DiaChiNR, item.DiaChiCQ, item.DienThoai, item.MaPhong);
                }
                string filename = "DanhSachNhanSu" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xlsx";
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