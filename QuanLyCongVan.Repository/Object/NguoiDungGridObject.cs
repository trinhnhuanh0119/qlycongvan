using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
   public class NguoiDungGridObject
    {
        public int Id { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool? KichHoat { get; set; }
        public string MaNhanSu { get; set; }
        public string TongSo { get; set; }
    }
}
