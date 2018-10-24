using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class TDKController : Controller
    {
        ITDKService _tdkService;

        public TDKController(ITDKService tdkService)
        {
            _tdkService = tdkService;
        }
        public async Task<IEnumerable<TDK>> GetAllTDKPostsByPageIndex()
        {
            var reseltData = await _tdkService.GetAllTDKByPageIndex(1, 6);

            return reseltData;
        }
    }
}