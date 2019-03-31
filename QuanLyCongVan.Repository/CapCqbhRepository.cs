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
    public class CapCqbhRepository :GenericRepository<CapCqbh>
    {
        public List<CapCQBHGridObject> GetAll(CapCQBHTableGridRequest request)
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaCapCQBH", request.MaCapCQBH);
                parameters.Add("@TenCapCQBH", request.TenCapCQBH);
                parameters.Add("@GhiChu", request.GhiChu);
                parameters.Add("@PageIndex", request.PageIndex);
                parameters.Add("@PageSize", request.PageSize);
                var list = db.Query<CapCQBHGridObject>("SearchallCapCQBH", parameters, null, true, null, CommandType.StoredProcedure).AsList<CapCQBHGridObject>();
                return list;
            }

        }
        public List<DropDownsCCQBHObject> GetDropDowns()
        {
            using (IDbConnection db = new SqlConnection(Connections.Connection))
            {
                DynamicParameters parameters = new DynamicParameters();
                var list = db.Query<DropDownsCCQBHObject>("DropCcqbh", parameters, null, true, null, CommandType.StoredProcedure).AsList<DropDownsCCQBHObject>();
                return list;
            }
        }
    }
}
