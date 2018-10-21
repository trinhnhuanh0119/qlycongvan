using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class DoMatController : Controller
    {
        IDoMatService _domatService;

        public DoMatController(IDoMatService domatService)
        {
            _domatService =domatService;
        }
        public async Task<IEnumerable<DoMat>> GetAllDoMatPostsByPageIndex()
        {
            var reseltData = await _domatService.GetAllDoMatByPageIndex(1, 6);

            return reseltData;
        }
    }
}