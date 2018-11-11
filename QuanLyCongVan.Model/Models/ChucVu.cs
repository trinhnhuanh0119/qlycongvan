using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class ChucVu
    {
        public int Id { get; set; }
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public double? HeSoChucVu { get; set; }
        public string MoTa { get; set; }
    }
}
