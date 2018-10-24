using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class LoaiBQService: ILoaiBQService
    {

        IUnitOfWork _unitOfWork;
        public LoaiBQService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<LoaiBQ>> GetAllLoaiBQByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.LoaiBQRepository.GetAllLoaiBQByPageIndex(pageIndex, pageSize);
        }
    }
}
