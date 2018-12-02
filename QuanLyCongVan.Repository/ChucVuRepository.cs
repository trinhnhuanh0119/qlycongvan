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
    public class ChucVuRepository : GenericRepository<ChucVu>
    {
        public List<ChucVuGridObject> GetAll(ChucVuTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaChucVu", request.MaChucVu);
                parameters.Add("@TenChucVu", request.TenChucVu);
                parameters.Add("@HeSoChucVu", request.HeSoChucVu);
                parameters.Add("@MoTa", request.MoTa);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<ChucVuGridObject>("SearchallChucVu", parameters, null, true, null, CommandType.StoredProcedure).AsList<ChucVuGridObject>();
                return list;
            }

        }
    }
}
