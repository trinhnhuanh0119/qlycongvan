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
    public class NguoiDungRepository : GenericRepository<NguoiDung>
    {
        public List<NguoiDungGridObject> GetAll(NguoiDungTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TenTaiKhoan", request.TenTaiKhoan);
                parameters.Add("@MatKhau", request.MatKhau);
                parameters.Add("@KichHoat", request.KichHoat);
                parameters.Add("@MaNhanSu", request.MaNhanSu);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<NguoiDungGridObject>("SearchallNguoiDung", parameters, null, true, null, CommandType.StoredProcedure).AsList<NguoiDungGridObject>();
                return list;
            }

        }
    }
}
