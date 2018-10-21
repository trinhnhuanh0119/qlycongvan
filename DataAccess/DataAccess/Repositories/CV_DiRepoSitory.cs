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
   public class CV_DiRepository :GenericRepository<CV_Di>,ICV_DiRepository
    {
        IConnectionFactory _connectionFactory;
        public CV_DiRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<IEnumerable<CV_Di>> GetAllCV_DiByPageIndex(int pageIndex, int pageSize)
        {
            var query = "usp_GetAllCV_DiPostByPageIndex";
            var param = new DynamicParameters();
            param.Add("@PageIndex", pageIndex);
            param.Add("@PageSize", pageSize);
            var list = await SqlMapper.QueryAsync<CV_Di>
                (_connectionFactory.GetConnection, query, param, commandType: CommandType.StoredProcedure);
            return list;
        }
    }
}
