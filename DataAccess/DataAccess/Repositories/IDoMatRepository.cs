using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IDoMatRepository : IGenericRepository<DoMat>
    {
        Task<IEnumerable<DoMat>> GetAllDoMatByPageIndex(int pageIndex, int pageSize);
    }
}
