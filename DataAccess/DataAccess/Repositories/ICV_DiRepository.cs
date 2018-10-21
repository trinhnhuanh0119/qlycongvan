using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ICV_DiRepository : IGenericRepository<CV_Di>
    {
        Task<IEnumerable<CV_Di>> GetAllCV_DiByPageIndex(int pageIndex, int pageSize);
    }
}
