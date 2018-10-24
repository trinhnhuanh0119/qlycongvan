using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public interface INBHService
    {
        Task<IEnumerable<NBH>> GetAllNBHByPageIndex(int pageIndex, int pageSize);
    }
}
