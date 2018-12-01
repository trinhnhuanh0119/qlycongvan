using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;

namespace QuanLyCongVan.Controllers
{
    public class MenuController : Controller
    {
        MenuRepository menuRepo = new MenuRepository();
        public IActionResult Index()
        {
            var listMenu = menuRepo.GetAll();
            return View(listMenu);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Menu m)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    menuRepo.Create(m);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(m);
        }
    }
}