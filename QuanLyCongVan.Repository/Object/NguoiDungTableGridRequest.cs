using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
    public class NguoiDungTableGridRequest
    {
        public int Id { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool? KichHoat { get; set; }
        public string MaNhanSu { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
