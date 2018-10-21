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
    public class CCQBHRepository : GenericRepository<CCQBH>, ICCQBHRepository
    {
        IConnectionFactory connectionFactory;
        public CCQBHRepository(IConnectionFactory connectionFactory)
        {
            connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<CCQBH>> GetAllCCQBHByPageIndex(int pageindex, int pageSize)
        {
            var query = "usp_GetAllCCQBHPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageindex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<CCQBH>
                (connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
    
}
