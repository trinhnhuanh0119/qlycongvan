using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class DoKhanController : Controller
    {
        IDoKhanService _dokhanService;

        public DoKhanController(IDoKhanService dokhanService)
        {
            _dokhanService = dokhanService;
        }
        public async Task<IEnumerable<DoKhan>> GetAllDoKhanPostsByPageIndex()
        {
            var reseltData = await _dokhanService.GetAllDoKhanByPageIndex(1, 6);

            return reseltData;
        }
    }
}