using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public interface IDVRepository :IGenericRepository<DV>
    {
        Task<IEnumerable<DV>> GetAllDVByPageIndex(int pageIndex, int pageSize);
    }
}
