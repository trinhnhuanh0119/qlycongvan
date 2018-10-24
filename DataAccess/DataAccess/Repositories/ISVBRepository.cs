using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ISVBRepository : IGenericRepository<SVB>
    {
        Task<IEnumerable<SVB>> GetAllSVBByPageIndex(int pageIndex, int pageSize);
    }
}
