using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IMenuRepository : IGenericRepository<Menu>
    {
        Task<IEnumerable<Menu>> GetAllMenuByPageIndex(int pageIndex, int pageSize);
    }
}
