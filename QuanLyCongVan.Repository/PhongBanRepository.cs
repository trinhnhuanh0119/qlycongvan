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
    public class PhongBanRepository : GenericRepository<PhongBan>
    {
        public List<PhongBanGridObject> GetAll(PhongBanTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaPhong", request.MaPhong);
                parameters.Add("@TenPhong", request.TenPhong);
                parameters.Add("@DienThoai", request.DienThoai);
                parameters.Add("@Fax", request.Fax);
                parameters.Add("@MaNhanSu", request.MaNhanSu);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<PhongBanGridObject>("SearchallPhongBan", parameters, null, true, null, CommandType.StoredProcedure).AsList<PhongBanGridObject>();
                return list;
            }

        }
        public List<DropDownObject> GetDropDowns()
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                var list = db.Query<DropDownObject>("DropPB", parameters,null, true, null, CommandType.StoredProcedure).AsList<DropDownObject>();
                return list;
            }
        }
    }
}