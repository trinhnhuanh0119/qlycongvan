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
    public class CapCqbhController : Controller
    {
        CapCqbhRepository capcqbhRepo= new CapCqbhRepository();
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
            catch (Exception )
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
    }
}