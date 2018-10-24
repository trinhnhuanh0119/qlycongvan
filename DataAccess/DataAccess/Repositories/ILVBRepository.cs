using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ILVBRepository :IGenericRepository<LVB>
    {
        Task<IEnumerable<LVB>> GetAllLVBByPageIndex(int pageIndex, int pageSize);
    }
}

