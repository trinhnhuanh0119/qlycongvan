using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
   public class PhongBanTableGridRequest
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string MaNhanSu { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
