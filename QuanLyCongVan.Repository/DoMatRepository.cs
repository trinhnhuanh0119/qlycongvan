using Dapper;
using QuanLyCongVan.Model.Models;
using QuanLyCongVan.Repository.Base;
using QuanLyCongVan.Repository.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QuanLyCongVan.Repository
{
    public class DoMatRepository : GenericRepository<DoMat>
    {
        public List<DoMatGridObject> GetAll(DoMatTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@DoMat", request.DoMat);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<DoMatGridObject>("SearchallDoMat", parameters, null, true, null, CommandType.StoredProcedure).AsList<DoMatGridObject>();
                return list;
            }

        }
    }
}
