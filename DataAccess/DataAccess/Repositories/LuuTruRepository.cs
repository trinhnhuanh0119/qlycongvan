using Dapper;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public class LuuTruRepository : GenericRepository<LuuTru>,ILuuTruRepository
    {
        IConnectionFactory _connectionFactory;
        public LuuTruRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<LuuTru>> GetAllLuuTruByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllLuuTruPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<LuuTru>
                (_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
