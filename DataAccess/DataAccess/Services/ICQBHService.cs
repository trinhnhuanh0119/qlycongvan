using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ICQBHService
    {
        Task<IEnumerable<CQBH>> GetAllCQBHByPageIndex(int pageIndex, int pageSize);
    }
}
