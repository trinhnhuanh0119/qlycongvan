﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository;
using QuanLyCongVan.Repository.Object;

namespace QuanLyCongVan.Controllers
{
    public class DoMatController : Controller
    {
        DoMatRepository domatRepo = new DoMatRepository();
        public ActionResult Index()
        {
            var listDoMat = domatRepo.GetAll();
            return View(listDoMat);
        }

        [HttpPost]
        public ActionResult Create([FromBody]DoMat c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    domatRepo.Create(c);
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
            var domat = domatRepo.GetById(id);
            return Json(domat);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                domatRepo.Delete(id);
                return Json(true);
            }
            catch (Exception )
            {
                return Json(false);
            }
            
        }
        [HttpPost]
        public JsonResult getAllSearch([FromBody]DoMatTableGridRequest request)
        {
            return Json(domatRepo.GetAll(request));
        }

        public ActionResult Update ([FromBody]DoMat c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    domatRepo.Update(c);
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