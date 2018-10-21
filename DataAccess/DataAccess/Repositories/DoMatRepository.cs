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
   public class DoMatRepository : GenericRepository<DoMat>, IDoMatRepository
    {
        IConnectionFactory _connectionFactory;
        public DoMatRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<DoMat>> GetAllDoMatByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllDoMatPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<DoMat>
                (_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
