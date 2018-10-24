using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public interface IPhongRepository : IGenericRepository<Phong>
    {
        Task<IEnumerable<Phong>> GetAllPhongByPageIndex(int pageIndex, int pageSize);
    }
}
