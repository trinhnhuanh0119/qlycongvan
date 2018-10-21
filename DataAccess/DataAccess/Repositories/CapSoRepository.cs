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
   public class CapSoRepository : GenericRepository<CapSo>,ICapSoRepository
    {
        IConnectionFactory _connectionFactory;
        public CapSoRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<CapSo>> GetAllCapSoByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllCapSoPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<CapSo>
                (_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
