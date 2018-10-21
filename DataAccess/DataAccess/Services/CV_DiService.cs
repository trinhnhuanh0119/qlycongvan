using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class CV_DiService : ICV_DiService
    {
        IUnitOfWork _unitOfWork;
        public CV_DiService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CV_Di>> GetAllCV_DiByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.CV_DiRepository.GetAllCV_DiByPageIndex(pageIndex, pageSize);
        }
    }
}
