using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public class UsersService :IUsersService
    {
        IUnitOfWork _unitOfWork;
        public UsersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Users>> GetAllUsersByPageIndex(int pageIndex, int pageSize)
        {
            return await _unitOfWork.UsersRepository.GetAllUsersByPageIndex(pageIndex, pageSize);
        }
    }
}
