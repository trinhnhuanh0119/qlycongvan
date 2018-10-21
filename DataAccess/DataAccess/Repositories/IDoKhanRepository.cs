using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IDoKhanRepository : IGenericRepository<DoKhan>
    {
        Task<IEnumerable<DoKhan>> GetAllDoKhanByPageIndex(int pageIndex, int pageSize);
    }
}
