using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class CCQBHService : ICCQBHService 
    {
        IUnitOfWork _unitOfWork;
        public CCQBHService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CCQBH>> GetAllCCQBHByPageIndex(int pageIndex,int pageSize)
        {
            return await _unitOfWork.CCQBHRepository.GetAllCCQBHByPageIndex(pageIndex, pageSize);
        }
    }
}
