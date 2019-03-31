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
    public class CapCqbhController : Controller
    {
        CapCqbhRepository capcqbhRepo = new CapCqbhRepository();
        private IHostingEnvironment _env; 
        public CapCqbhController(IHostingEnvironment env)
        {
            _env = env;
        }
        public ActionResult Index()
        {
            var listCapCqbh = capcqbhRepo.GetAll();
            return View(listCapCqbh);
        }

        [HttpPost]
        public ActionResult Create([FromBody]CapCqbh c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    capcqbhRepo.Create(c);
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
            var capcqbh = capcqbhRepo.GetById(id);
            return Json(capcqbh);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                capcqbhRepo.Delete(id);
                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }

        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]CapCQBHTableGridRequest request)
        {
            return Json(capcqbhRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update([FromBody]CapCqbh c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    capcqbhRepo.Update(c);
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
        public ActionResult GetDropDowns()
        {
            return Json(capcqbhRepo.GetDropDowns());
        }

        [HttpPost]
        public ActionResult ExportExcel()
        {
            try
            {
                var webRoot = _env.WebRootPath;
                DataTable dt = new DataTable();
                QuanLyCongVanContext db = new QuanLyCongVanContext();
                var paht = System.IO.Path.Combine(webRoot, "Content/TempExcel/CapCQBH.xlsx");
                Workbook wb = new Workbook();

                //Cell Cells = char.Parse(new Cell["A3"].ToString());
                Worksheet ws = wb.Worksheets[0];
                dt.Columns.Add("Mã");
                dt.Columns.Add("Tên cấp cơ quan ban hành");
                dt.Columns.Add("Ghi chú");
                List<CapCqbh> listcapCqbh = new List<CapCqbh>();
                listcapCqbh = db.CapCqbh.ToList();
                string listcapCqbhs = "";
                if (listcapCqbh.Count > 0)
                {
                    listcapCqbhs = String.Join(",", listcapCqbh.Select(x => x.ToString()).ToArray());
                }
                var ob = new CapCqbhRepository();
                var data = ob.GetAll();
                foreach (CapCqbh item in data)
                {
                    dt.Rows.Add(item.MaCapCqbh, item.TenCapCqbh, item.GhiChu);
                }
                string filename = "DanhSachCapCQBH" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xlsx";
                string folderName = "/assets/Excel/";

                var file = System.IO.Path.Combine(webRoot + folderName + filename);
                if (!System.IO.Directory.Exists(folderName))
                {
                    System.IO.Directory.CreateDirectory(folderName);
                }
                ws.Cells.ImportDataTable(dt, false, 2, 0);
                wb.Save(file);
                return Json(folderName + filename);
            } catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}