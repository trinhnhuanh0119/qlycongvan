using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class LuuTruController : Controller
    {
        ILuuTruService _luutruService;

        public LuuTruController(ILuuTruService luutruService)
        {
            _luutruService = luutruService;
        }
        public async Task<IEnumerable<LuuTru>> GetAllLuuTruPostsByPageIndex()
        {
            var reseltData = await _luutruService.GetAllLuuTruByPageIndex(1, 6);

            return reseltData;
        }
    }
}