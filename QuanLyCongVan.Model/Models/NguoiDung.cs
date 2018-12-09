using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class NguoiDung
    {
        public int Id { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int KichHoat { get; set; }
        public string MaNhanSu { get; set; }
    }
}
