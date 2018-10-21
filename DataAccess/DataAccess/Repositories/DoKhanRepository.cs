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
    public class DoKhanRepository : GenericRepository<DoKhan>, IDoKhanRepository
    {
        IConnectionFactory _connectionFactory;
        public DoKhanRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<DoKhan>> GetAllDoKhanByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllDoKhanPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<DoKhan>
               (_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
