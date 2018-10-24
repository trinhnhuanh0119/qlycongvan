using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class KhoLuuTruService : IKhoLuuTruService
    {

        IUnitOfWork _unitOfWork;
        public KhoLuuTruService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<KhoLuuTru>> GetAllKhoLuuTruByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.KhoLuuTruRepository.GetAllKhoLuuTruByPageIndex(pageIndex, pageSize);
        }
    }
}
