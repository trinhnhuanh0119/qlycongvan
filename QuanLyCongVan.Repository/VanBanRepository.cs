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
    public class VanBanRepository : GenericRepository<VanBan>
    {
        public List<VanBanGridObject> GetAll(VanBanTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@VBDiDen", request.VbdiDen);
                parameters.Add("@MaLoaiVB", request.MaLoaiVb);
                parameters.Add("@MaCQBH", request.MaCqbh);
                parameters.Add("@SoVB", request.SoVb);
                parameters.Add("@SoDen", request.SoDen);
                parameters.Add("NgayDen", request.NgayDen);
                parameters.Add("@DoMat", request.DoMat);
                parameters.Add("@DoKhan", request.DoKhan);
                parameters.Add("@TrichYeu", request.TrichYeu);
                parameters.Add("@NoiNhan", request.NgayKy);
                parameters.Add("@NguoiKy", request.NguoiKy);
                parameters.Add("@KetQuaXuLy", request.KetQuaXuLy);
                parameters.Add("@FileDinhKem", request.FileDinhKem);
                parameters.Add("@HanXuLy", request.HanXuLy);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<VanBanGridObject>("SearchallVanBan", parameters, null, true, null, CommandType.StoredProcedure).AsList<VanBanGridObject>();
                return list;
            }

        }
    }
}
