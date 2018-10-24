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
   public class LoaiBQRepository : GenericRepository<LoaiBQ>,ILoaiBQRepository
    {
        IConnectionFactory _connectionFactory;
        public LoaiBQRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<LoaiBQ>> GetAllLoaiBQByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllLoaiBQPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<LoaiBQ>
                (_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
