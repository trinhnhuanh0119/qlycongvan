using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
    public class LoaiVanBanGridObject
    {
        public int Id { get; set; }
        public string MaLoaiVB { get; set; }
        public string TenLoaiVB { get; set; }
        public string TenVietTat { get; set; }
        public byte Di { get; set; }
        public byte Den { get; set; }
        public int TongSo { get; set; }
    }
}
