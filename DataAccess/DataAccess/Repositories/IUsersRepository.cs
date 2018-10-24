using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public interface  IUsersRepository : IGenericRepository<Users>
    {
        Task<IEnumerable<Users>> GetAllUsersByPageIndex(int pageIndex, int pageSize);
    }
}
