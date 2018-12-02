using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository.Object;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using QuanLyCongVan.Repository.Base;

namespace QuanLyCongVan.Repository
{
    public class DoKhanRepository : GenericRepository<DoKhan>
    {
        public List<DoKhanGridObject> GetAll(DoKhanTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@DoKhan",request.DoKhan);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<DoKhanGridObject>("SearchallDoKhan", parameters, null, true, null, CommandType.StoredProcedure).AsList<DoKhanGridObject>();
                return list;
            }

        }
    }
}
