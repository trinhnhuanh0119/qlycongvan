using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
   public class NhanSuGridObject
    {
        public int Id { get; set; }
        public string MaNhanSu { get; set; }
        public string Ho { get; set; }
        public string Dem { get; set; }
        public string Ten { get; set; }
        public string TenVietTat { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Anh { get; set; }
        public DateTime? NgayVaoNganh { get; set; }
        public string DiaChiNr { get; set; }
        public string DiaChiCq { get; set; }
        public string DienThoai { get; set; }
        public string MaPhong { get; set; }
        public int TongSo { get; set; }
    }
}
