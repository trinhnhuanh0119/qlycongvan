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
    public class VanBanController : Controller
    {
        VanBanRepository vanbanRepo = new VanBanRepository();
        private IHostingEnvironment _env;

        public VanBanController(IHostingEnvironment env)
        {
            _env = env;
        }
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

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                vanbanRepo.Delete(id);
                return Json(true);
            }
            catch (Exception )
            {
                return Json(false);
            }
        }

        [HttpPost]
        public JsonResult getAllSearch([FromBody]VanBanTableGridRequest request)
        {
            return Json(vanbanRepo.GetAll(request));
        }

        [HttpPost]
        public ActionResult Update ([FromBody]VanBan c)
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

        [HttpPost]
        public ActionResult ExportExcel()
        {
            try
            {
                var webRoot = _env.WebRootPath;
                DataTable dt = new DataTable();
                QuanLyCongVanContext db = new QuanLyCongVanContext();
                var paht = System.IO.Path.Combine(webRoot, "Content/TempExcel/VanBan.xlsx");
                Workbook wb = new Workbook();

                //Cell Cells = char.Parse(new Cell["A3"].ToString());
                Worksheet ws = wb.Worksheets[0];
                dt.Columns.Add("Văn bản đi đến");
                dt.Columns.Add("Mã loại VB"); ;
                dt.Columns.Add("Mã CQBH");
                dt.Columns.Add("Số VB");
                dt.Columns.Add("Số đến");
                dt.Columns.Add("Ngày đến");
                dt.Columns.Add("Độ mật");
                dt.Columns.Add("Độ khẩn");
                dt.Columns.Add("Số đến");
                dt.Columns.Add("Trích yếu");
                dt.Columns.Add("Nơi nhận");
                dt.Columns.Add("Ngày ký");
                dt.Columns.Add("Người ký");
                dt.Columns.Add("Kết quả xử lý");
                dt.Columns.Add("File đính kèm");
                List<VanBan> listvb = new List<VanBan>();
                listvb = db.VanBan.ToList();
                string listvbs = "";
                if (listvb.Count > 0)
                {
                    listvbs = String.Join(",", listvb.Select(x => x.ToString()).ToArray());
                }
                var ob = new VanBanRepository();
                var data = ob.GetAll();
                foreach (VanBan item in data)
                {
                    dt.Rows.Add(item.VbdiDen, item.MaLoaiVb, item.MaCqbh, item.SoVb, item.SoDen,Convert.ToDateTime(item.NgayDen),
                        item.DoMat,item.DoKhan,item.TrichYeu,item.NoiNhan,Convert.ToDateTime(item.NgayKy),item.NguoiKy,item.KetQuaXuLy,item.FileDinhKem);
                }
                string filename = "DanhSachVanBan" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xlsx";
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