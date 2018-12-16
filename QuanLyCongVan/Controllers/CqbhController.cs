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
    public class CqbhController : Controller
    {
        CqbhRepository cqbhRepo = new CqbhRepository();
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
            return View(cqbh);
        }

        [HttpPost]
        public ActionResult Edit(Cqbh c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cqbhRepo.Update(c);
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
                cqbhRepo.Delete(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]CQBHTableGridRequest request)
        {
            return Json(cqbhRepo.GetAll(request));
        }
    }
}