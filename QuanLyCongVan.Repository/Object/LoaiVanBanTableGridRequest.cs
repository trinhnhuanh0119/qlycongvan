using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
    public class LoaiVanBanTableGridRequest
    {
        public int Id { get; set; }
        public string MaLoaiVB { get; set; }
        public string TenLoaiVB { get; set; }
        public string TenVietTat { get; set; }
        public int KieuVanBan { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public byte Di { get; set; }
        public byte Den { get; set; }
    }
}
