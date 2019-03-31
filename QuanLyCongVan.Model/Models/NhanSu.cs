using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class NhanSu
    {
        public int Id { get; set; }
        public string MaNhanSu { get; set; }
        public string Ho { get; set; }
        public string Dem { get; set; }
        public string Ten { get; set; }
        public string TenVietTat { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Anh { get; set; }
        public DateTime? NgayVaoNganh { get; set; }
        public string DiaChiNr { get; set; }
        public string DiaChiCq { get; set; }
        public string DienThoai { get; set; }
        public string MaPhong { get; set; }
    }

    public class NhanSuInsert
    {
     
        public string maNhanSu { get; set; }
        public string ten { get; set; }
        public int? gioiTinh { get; set; }
        public string ngaySinh { get; set; }
        public string diaChiNr { get; set; }
        public string diaChiCq { get; set; }
        public string dienThoai { get; set; }
        public string maPhong { get; set; }
    }
}
