using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class LuuTruService :ILuuTruService
    {
        IUnitOfWork _unitOfWork;
        public LuuTruService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<LuuTru>> GetAllLuuTruByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.LuuTruRepository.GetAllLuuTruByPageIndex(pageIndex, pageSize);
        }
    }
}
