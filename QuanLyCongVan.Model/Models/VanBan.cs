using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class VanBan
    {
        public VanBan()
        {
            FileVb = new HashSet<FileVb>();
        }

        public int Id { get; set; }
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

        public ICollection<FileVb> FileVb { get; set; }
    }
    public class VanBanInsert
    {
        public int Id { get; set; }
        public bool? VbdiDen { get; set; }
        public string MaLoaiVb { get; set; }
        public string MaCqbh { get; set; }
        public string SoVb { get; set; }
        public string SoDen { get; set; }
        public string NgayDen { get; set; }
        public string DoMat { get; set; }
        public string DoKhan { get; set; }
        public string TrichYeu { get; set; }
        public string NoiNhan { get; set; }
        public string NgayKy { get; set; }
        public string NguoiKy { get; set; }
        public bool? KetQuaXuLy { get; set; }
        public bool? FileDinhKem { get; set; }
        public string HanXuLy { get; set; }
    }
}
