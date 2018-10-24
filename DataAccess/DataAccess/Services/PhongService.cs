using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class PhongService : IPhongService
    {
        IUnitOfWork _unitOfWork;
        public PhongService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Phong>> GetAllPhongByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.PhongRepository.GetAllPhongByPageIndex(pageIndex, pageSize);
        }
    }
}
