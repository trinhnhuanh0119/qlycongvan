using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class PhongController : Controller
    {
        IPhongService _phongService;

        public PhongController(IPhongService phongService)
        {
            _phongService = phongService;
        }
        public async Task<IEnumerable<Phong>> GetAllPhongPostsByPageIndex()
        {
            var reseltData = await _phongService.GetAllPhongByPageIndex(1, 6);

            return reseltData;
        }
    }
}