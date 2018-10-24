using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class NNDController : Controller
    {
        INNDService _nndService;

        public NNDController(INNDService nndService)
        {
            _nndService = nndService;
        }
        public async Task<IEnumerable<NND>> GetAllNNDPostsByPageIndex()
        {
            var reseltData = await _nndService.GetAllNNDByPageIndex(1, 6);

            return reseltData;
        }
    }
}