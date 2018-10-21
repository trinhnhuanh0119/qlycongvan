using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class DoKhanService
    {
        IUnitOfWork _unitOfWork;
        public DoKhanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DoKhan>> GetAllDoKhanByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.DoKhanRepository.GetAllDoKhanByPageIndex(pageIndex, pageSize);
        }
    }
}
