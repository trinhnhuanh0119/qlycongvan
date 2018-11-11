using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class LoaiVanBan
    {
        public int Id { get; set; }
        public string MaLoaiVb { get; set; }
        public string TenLoaiVb { get; set; }
        public string TenVietTat { get; set; }
        public bool? Di { get; set; }
        public bool? Den { get; set; }
    }
}
