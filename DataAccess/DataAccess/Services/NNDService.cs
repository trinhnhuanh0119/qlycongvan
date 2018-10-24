using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class NNDService :INNDService
    {
        IUnitOfWork _unitOfWork;
        public NNDService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<NND>> GetAllNNDByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.NNDRepository.GetAllNNDByPageIndex(pageIndex, pageSize);
        }
    }
}
