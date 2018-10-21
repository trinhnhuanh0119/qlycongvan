using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
   public interface IDoKhanService
    {
        Task<IEnumerable<DoKhan>> GetAllDoKhanByPageIndex(int pageIndex, int pageSize);
    }
}
