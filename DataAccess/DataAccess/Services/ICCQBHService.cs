using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ICCQBHService
    {
        Task<IEnumerable<CCQBH>> GetAllCCQBHByPageIndex(int pageIndex, int pageSize);
    }
}
