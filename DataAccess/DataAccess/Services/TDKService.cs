using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class TDKService :ITDKService
    {
        IUnitOfWork _unitOfWork;
        public TDKService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<TDK>> GetAllTDKByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.TDKRepository.GetAllTDKByPageIndex(pageIndex, pageSize);
        }
    }
}
