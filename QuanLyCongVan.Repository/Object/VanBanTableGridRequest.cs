using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
    public class VanBanTableGridRequest
    {
        public bool? VbdiDen { get; set; }
        public string MaLoaiVb { get; set; }
        public string MaCqbh { get; set; }
        public string SoVb { get; set; }
        public string SoDen { get; set; }
        public DateTime? NgayDen { get; set; }
        public string DoMat { get; set; }
        public string DoKhan { get; set; }
        public string TrichYeu { get; set; }
        public string NoiNhan { get; set; }
        public DateTime? NgayKy { get; set; }
        public string NguoiKy { get; set; }
        public bool? KetQuaXuLy { get; set; }
        public bool? FileDinhKem { get; set; }
        public DateTime? HanXuLy { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
