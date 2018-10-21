using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class CapSoController : Controller
    {
        ICapSoService _capsoService;

        public CapSoController(ICapSoService capsoService)
        {
            _capsoService = capsoService;
        }
        public async Task<IEnumerable<CapSo>> GetAllCapSoPostsByPageIndex()
        {
            var reseltData = await _capsoService.GetAllCapSoByPageIndex(1, 6);

            return reseltData;
        }
    }
}