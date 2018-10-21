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
   public class DVRepository :GenericRepository<DV>,IDVRepository
    {
        IConnectionFactory  _connectionFactory;
        public DVRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<DV>> GetAllDVByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllDVPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<DV>
                (_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
