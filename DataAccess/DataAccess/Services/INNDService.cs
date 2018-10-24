using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface INNDService
    {
        Task<IEnumerable<NND>> GetAllNNDByPageIndex(int pageIndex, int pageSize);
    }
}
