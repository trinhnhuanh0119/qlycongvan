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
   public class KhoLuuTruRepository : GenericRepository<KhoLuuTru>,IKhoLuuTruRepository
    {
        IConnectionFactory _connectionFactory;
        public KhoLuuTruRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<KhoLuuTru>> GetAllKhoLuuTruByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllKhoLuuTruPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<KhoLuuTru>
                (_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
