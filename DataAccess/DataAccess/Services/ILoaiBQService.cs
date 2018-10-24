using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ILoaiBQService
    {
        Task<IEnumerable<LoaiBQ>> GetAllLoaiBQByPageIndex(int pageIndex, int pageSize);
    }
}
