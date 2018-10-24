using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ITDKService
    {
        Task<IEnumerable<TDK>> GetAllTDKByPageIndex(int pageIndex, int pageSize);
    }
}
