using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;

namespace QuanLyCongVan.Controllers
{
    public class CapCqbhController : Controller
    {
        CapCqbhRepository capcqbhRepo= new CapCqbhRepository();
        public ActionResult Index()
        {
            var listCapCqbh = capcqbhRepo.GetAll();
            return View(listCapCqbh);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CapCqbh c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    capcqbhRepo.Create(c);
                    return RedirectToAction("index");
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
            return View(capcqbh);
        }

        [HttpPost]
        public ActionResult Edit(CapCqbh c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    capcqbhRepo.Update(c);
                    return RedirectToAction("index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(c);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                capcqbhRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
    }
}