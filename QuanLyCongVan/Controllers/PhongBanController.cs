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
    public class PhongBanController : Controller
    {
        PhongBanRepository phongbanRepo = new PhongBanRepository();
        private IHostingEnvironment _env;
        public PhongBanController(IHostingEnvironment env)
        {
            _env = env;
        }
        public ActionResult Index()
        {
            var listPhongBan = phongbanRepo.GetAll();
            return View(listPhongBan);
        }

        [HttpPost]
        public ActionResult Create([FromBody]PhongBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    phongbanRepo.Create(c);
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
            var phongban = phongbanRepo.GetById(id);
            return Json(phongban);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                phongbanRepo.Delete(id);
                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]PhongBanTableGridRequest request)
        {
            return Json(phongbanRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]PhongBan c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   phongbanRepo.Update(c);
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
        public ActionResult DropPB()
        {
            return Json(phongbanRepo.GetDropDowns());
        }

        [HttpPost]
        public ActionResult ExportExcel()
        {
            try
            {
                var webRoot = _env.WebRootPath;
                DataTable dt = new DataTable();
                QuanLyCongVanContext db = new QuanLyCongVanContext();
                var paht = System.IO.Path.Combine(webRoot, "Content/TempExcel/PhongBan.xlsx");
                Workbook wb = new Workbook();

                //Cell Cells = char.Parse(new Cell["A3"].ToString());
                Worksheet ws = wb.Worksheets[0];
                dt.Columns.Add("Mã phòng");
                dt.Columns.Add("Tên");;
                dt.Columns.Add("Điện  thoại");
                dt.Columns.Add("Fax");
                dt.Columns.Add("Mã nhân sự");
                List<PhongBan> listpb = new List<PhongBan>();
                listpb = db.PhongBan.ToList();
                string listpbs = "";
                if (listpb.Count > 0)
                {
                    listpbs = String.Join(",", listpb.Select(x => x.ToString()).ToArray());
                }
                var ob = new PhongBanRepository();
                var data = ob.GetAll();
                foreach (PhongBan item in data)
                {
                    dt.Rows.Add(item.MaPhong, item.TenPhong, item.DienThoai, item.Fax, item.MaNhanSu);
                }
                string filename = "DanhSachPhongBan" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xlsx";
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