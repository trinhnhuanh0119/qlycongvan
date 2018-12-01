using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuanLyCongVan.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        MenuRepository menuRepo = new MenuRepository();
        public ActionResult Index()
        {
            return View();
        }
        public List<MenuViewModel> GetMenu()
        {
            try
            {
                List<MenuViewModel> result = new List<MenuViewModel>();
                using(var db = new QuanLyCongVanContext())
                {
                    //Get Data 
                    var Data = db.Menu.Where(c => c.ParentId == 0 && c.TrangThai == true).Select(x => new MenuViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ParentId = x.ParentId,
                        TrangThai = x.TrangThai,
                        CSS = x.CSS,
                        LinkView = x.LinkView,
                        SubMenu = GetSubMenu(x.Id)
                    }).ToList();
                    // Sap xep lai Data
                    result = Data;
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private List<MenuViewModel> GetSubMenu(int ParrentId)
        {
            List<MenuViewModel> submenu = new List<MenuViewModel>();

            using (var db = new QuanLyCongVanContext())
            {
                submenu = db.Menu.Where(x => x.ParentId == ParrentId && x.TrangThai == true)
                    .Select(x => new MenuViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ParentId = x.ParentId,
                        TrangThai = x.TrangThai,
                        CSS = x.CSS,
                        LinkView = x.LinkView,
                        SubMenu = GetSubMenu(x.Id)
                    }).ToList();
            }
            return submenu;
        }
    }
}
