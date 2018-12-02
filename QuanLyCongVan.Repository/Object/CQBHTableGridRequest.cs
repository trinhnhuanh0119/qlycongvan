using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
    public class CQBHTableGridRequest
    {
        public string MaCQBH { get; set; }
        public string TenCQBH { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string GhiChu { get; set; }
        public string TenVietTat { get; set; }
        public string MaCapCQBH { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
