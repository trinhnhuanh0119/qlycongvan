using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class NNVBService :INNVBService
    {
        IUnitOfWork _unitOfWork;
        public NNVBService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<NNVB>> GetAllNNVBByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.NNVBRepository.GetAllNNVBByPageIndex(pageIndex, pageSize);
        }
    }
}
