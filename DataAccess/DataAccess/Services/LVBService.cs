using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class LVBService: ILVBService
    {
        IUnitOfWork _unitOfWork;
        public LVBService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<LVB>> GetAllLVBByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.LVBRepository.GetAllLVBByPageIndex(pageIndex, pageSize);
        }
    }
}
