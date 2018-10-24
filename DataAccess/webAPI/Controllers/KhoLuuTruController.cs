using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class KhoLuuTruController : Controller
    {
        IKhoLuuTruService _kholuutruService;

        public KhoLuuTruController(IKhoLuuTruService kholuutruService)
        {
            _kholuutruService = kholuutruService;
        }
        public async Task<IEnumerable<KhoLuuTru>> GetAllKhoLuuTruPostsByPageIndex()
        {
            var reseltData = await _kholuutruService.GetAllKhoLuuTruByPageIndex(1, 6);

            return reseltData;
        }
    }
}