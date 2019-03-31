using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class NguoiDung
    {
        public int Id { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool? KichHoat { get; set; }
        public string MaNhanSu { get; set; }
    }
    public class NguoiDungInsert
    {
        public string tenTaiKhoan { get; set; }
        public string matKhau { get; set; }
        public int? kichHoat { get; set; }
        public string maNhanSu { get; set; }
    }
}
