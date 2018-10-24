using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class LVBController : Controller
    {
        ILVBService _lvbService;

        public LVBController(ILVBService lvbService)
        {
            _lvbService = lvbService;
        }
        public async Task<IEnumerable<LVB>> GetAllLVBPostsByPageIndex()
        {
            var reseltData = await _lvbService.GetAllLVBByPageIndex(1, 6);

            return reseltData;
        }
    }
}