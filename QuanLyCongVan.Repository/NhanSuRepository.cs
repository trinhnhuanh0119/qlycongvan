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
    public class NhanSuRepository : GenericRepository<NhanSu>
    {
        public List<NhanSuGridObject> GetAll(NhanSuTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaNhanSu", request.MaNhanSu);
                parameters.Add("@Ten", request.Ten);
                parameters.Add("@GioiTinh", request.GioiTinh);
                parameters.Add("@NgaySinh", request.NgaySinh );
                parameters.Add("@Anh", request.Anh);
                parameters.Add("@NgayVaoNganh", request.NgayVaoNganh);
                parameters.Add("@DiaChiNr", request.DiaChiNr);
                parameters.Add("@DiaChiCq", request.DiaChiCq);
                parameters.Add("@Dienthoai", request.DienThoai);
                parameters.Add("@MaPhong", request.MaPhong);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<NhanSuGridObject>("SearchallNhanSu", parameters, null, true, null, CommandType.StoredProcedure).AsList<NhanSuGridObject>();
                return list;
            }

        }
        public List<DropDownsNDObject> GetDropDowns()
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                var list = db.Query<DropDownsNDObject>("DropNS", parameters, null, true, null, CommandType.StoredProcedure).AsList<DropDownsNDObject>();
                return list;
            }
        }
    }
}
