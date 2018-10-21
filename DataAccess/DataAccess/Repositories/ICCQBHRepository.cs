using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ICCQBHRepository : IGenericRepository<CCQBH>
    {
        Task<IEnumerable<CCQBH>> GetAllCCQBHByPageIndex(int pageIndex, int pageSize);
    }
}
