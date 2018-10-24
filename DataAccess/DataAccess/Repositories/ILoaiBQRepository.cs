using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ILoaiBQRepository : IGenericRepository<LoaiBQ>
    {
        Task<IEnumerable<LoaiBQ>> GetAllLoaiBQByPageIndex(int pageIndex, int pageSize);
    }
}
