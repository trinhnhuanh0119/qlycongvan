using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class CQBHService :ICQBHService
    {
        IUnitOfWork _unitOfWork;
        public CQBHService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CQBH>> GetAllCQBHByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.CQBHRepository.GetAllCQBHByPageIndex(pageIndex, pageSize);
        }
    }
}
