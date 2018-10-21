using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class DoMatService :IDoMatService
    {
        IUnitOfWork _unitOfWork;
        public DoMatService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DoMat>> GetAllDoMatByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.DoMatRepository.GetAllDoMatByPageIndex(pageIndex, pageSize);
        }
    }
}
