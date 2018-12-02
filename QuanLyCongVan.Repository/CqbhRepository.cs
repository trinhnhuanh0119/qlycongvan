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
    public class CqbhRepository : GenericRepository<Cqbh>
    {
        public List<CQBHGridOject> GetAll(CQBHTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaCQBH", request.MaCQBH);
                parameters.Add("@TenCQBH", request.TenCQBH);
                parameters.Add("@DiaChi", request.DiaChi);
                parameters.Add("@DienThoai", request.DienThoai);
                parameters.Add("@Fax", request.Fax);
                parameters.Add("@Email", request.Email);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@TenVietTat", request.TenVietTat);
                parameters.Add("@MaCapCQBH", request.MaCapCQBH);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<CQBHGridOject>("SearchallCQBH", parameters, null, true, null, CommandType.StoredProcedure).AsList<CQBHGridOject>();
                return list;
            }

        }
    }
}
