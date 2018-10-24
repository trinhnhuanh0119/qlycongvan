using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface ILuuTruService
    {
        Task<IEnumerable<LuuTru>> GetAllLuuTruByPageIndex(int pageIndex, int pageSize);
    }
}
