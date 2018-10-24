using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class NBHService :INBHService
    {
        IUnitOfWork _unitOfWork;
        public NBHService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<NBH>> GetAllNBHByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.NBHRepository.GetAllNBHByPageIndex(pageIndex, pageSize);
        }
    }
}
