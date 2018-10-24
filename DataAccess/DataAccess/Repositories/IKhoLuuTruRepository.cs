using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public interface IKhoLuuTruRepository : IGenericRepository<KhoLuuTru>
    {
        Task<IEnumerable<KhoLuuTru>> GetAllKhoLuuTruByPageIndex(int pageIndex, int pageSize);
    }
}
