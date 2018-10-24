using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class NNVBController : Controller
    {
        INNVBService _nnvbService;

        public NNVBController(INNVBService nnvbService)
        {
            _nnvbService = nnvbService;
        }
        public async Task<IEnumerable<NNVB>> GetAllNNVBPostsByPageIndex()
        {
            var reseltData = await _nnvbService.GetAllNNVBByPageIndex(1, 6);

            return reseltData;
        }
    }
}