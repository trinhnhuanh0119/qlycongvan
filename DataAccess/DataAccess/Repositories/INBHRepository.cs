using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface INBHRepository : IGenericRepository<NBH>
    {
        Task<IEnumerable<NBH>> GetAllNBHByPageIndex(int pageIndex, int pageSize);
    }
}
