using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class PhongBan
    {
        public int Id { get; set; }
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string MaNhanSu { get; set; }
    }
}
