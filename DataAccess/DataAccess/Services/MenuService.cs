using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class MenuService : IMenuService
    {
        IUnitOfWork _unitOfWork;
        public MenuService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Menu>> GetAllMenuByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.MenuRepository.GetAllMenuByPageIndex(pageIndex, pageSize);
        }
    }
}
