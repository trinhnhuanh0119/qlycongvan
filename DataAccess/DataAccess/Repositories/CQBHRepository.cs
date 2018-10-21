using Dapper;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
   public class CQBHRepository : GenericRepository<CQBH>, ICQBHRepository
    {
        IConnectionFactory connectionFactory;
        public CQBHRepository(IConnectionFactory connectionFactory)
        {
            connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<CQBH>> GetAllCQBHByPageIndex(int pageIndex,int pageSize)
        {
            var query = "usp_GetAllCQBHPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<CQBH>
                (connectionFactory.GetConnection, query, param, commandType: System.Data.CommandType.StoredProcedure);
            return list;
        }
    }
}
