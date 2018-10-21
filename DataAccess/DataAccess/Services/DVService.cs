using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class DVService : IDVService
    {
        IUnitOfWork _unitOfWork;
        public DVService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DV>> GetAllDVByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.DVRepository.GetAllDVByPageIndex(pageIndex, pageSize);
        }
    }
}
