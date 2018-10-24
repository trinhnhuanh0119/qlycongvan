using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class LoaiBQController : Controller
    {
        ILoaiBQService _loaibqService;

        public LoaiBQController(ILoaiBQService loaibqService)
        {
            _loaibqService = loaibqService;
        }
        public async Task<IEnumerable<LoaiBQ>> GetAllLoaiBQPostsByPageIndex()
        {
            var reseltData = await _loaibqService.GetAllLoaiBQByPageIndex(1, 6);

            return reseltData;
        }
    }
}