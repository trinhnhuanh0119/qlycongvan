using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class CapSoService : ICapSoService
    {
        IUnitOfWork _unitOfWork;
        public CapSoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CapSo>> GetAllCapSoByPageIndex(int pageIndex,int pageSize)
        {
            return await _unitOfWork.CapSoRepository.GetAllCapSoByPageIndex(pageIndex, pageSize);
        }
    }
}
