using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ICV_DiService
    {
        Task<IEnumerable<CV_Di>> GetAllCV_DiByPageIndex(int pageIndex, int pageSize);
    }
}
