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
    public class CqbhController : Controller
    {
        CqbhRepository cqbhRepo = new CqbhRepository();
        private IHostingEnvironment _env;
        public CqbhController(IHostingEnvironment env)
        {
            _env = env;
        }
        public ActionResult Index()
        {
            var listCqbh = cqbhRepo.GetAll();
            return View(listCqbh);
        }
        [HttpPost]
        public ActionResult Create([FromBody]Cqbh c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cqbhRepo.Create(c);
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
            var cqbh = cqbhRepo.GetById(id);
            return Json(cqbh);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                cqbhRepo.Delete(id);
                return Json(true);
            }
            catch (Exception )
            {
                return Json(false);
            }
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]CQBHTableGridRequest request)
        {
            return Json(cqbhRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]Cqbh c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cqbhRepo.Update(c);
                    return Json(c);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(c);
        }

        [HttpPost]
        public ActionResult ExportExcel()
        {
            try
            {
                var webRoot = _env.WebRootPath;
                DataTable dt = new DataTable();
                QuanLyCongVanContext db = new QuanLyCongVanContext();
                var paht = System.IO.Path.Combine(webRoot, "Content/TempExcel/CQBH.xlsx");
                Workbook wb = new Workbook();

                //Cell Cells = char.Parse(new Cell["A3"].ToString());
                Worksheet ws = wb.Worksheets[0];
                dt.Columns.Add("Mã");
                dt.Columns.Add("Tên");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Điện thoại");
                dt.Columns.Add("Fax");
                dt.Columns.Add("Email");
                dt.Columns.Add("Ghi chú");
                dt.Columns.Add("Tên viết tắt");
                dt.Columns.Add("Mã cấp CQBH");
                List<Cqbh> listcqbh = new List<Cqbh>();
                listcqbh = db.Cqbh.ToList();
                string listcqbhs = "";
                if (listcqbh.Count > 0)
                {
                    listcqbhs = String.Join(",", listcqbh.Select(x => x.ToString()).ToArray());
                }
                var ob = new CqbhRepository();
                var data = ob.GetAll();
                foreach (Cqbh item in data)
                {
                    dt.Rows.Add(item.MaCqbh, item.TenCqbh, item.DiaChi,item.DienThoai,item.Fax,item.Email,item.GhiChu,item.TenVietTat,item.MaCapCqbh);
                }
                string filename = "DanhSachCQBH" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xlsx";
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