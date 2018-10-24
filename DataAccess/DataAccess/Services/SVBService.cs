using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class SVBService : ISVBService
    {
        IUnitOfWork _unitOfWork;
        public SVBService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<SVB>> GetAllSVBByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.SVBRepository.GetAllSVBByPageIndex(pageIndex, pageSize);
        }
    }
}
