﻿using Dapper;
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
    public class LoaiVanBanRepository : GenericRepository<LoaiVanBan>
    {
        public List<LoaiVanBanGridObject> GetAll(LoaiVanBanTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaLoaiVB", request.MaLoaiVB);
                parameters.Add("@TenLoaiVB", request.TenLoaiVB);
                parameters.Add("@TenVietTat", request.TenVietTat);
                parameters.Add("@KieuVanBan", request.KieuVanBan);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<LoaiVanBanGridObject>("SearchallLoaiVanBan", parameters, null, true, null, CommandType.StoredProcedure).AsList<LoaiVanBanGridObject>();
                return list;
            }

        }
        public List<DropDownLVBObject> GetDropDowns()
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                var list = db.Query<DropDownLVBObject>("DropLvb", parameters, null, true, null, CommandType.StoredProcedure).AsList<DropDownLVBObject>();
                return list;
            }
        }
    }
}
