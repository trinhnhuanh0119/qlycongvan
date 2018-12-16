using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
    public class ChucVuTableGridRequest
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public double? HeSoChucVu { get; set; }
        public string MoTa { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
