namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NND")]
    public partial class NND
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string TenNhom { get; set; }

        [StringLength(100)]
        public string MaNhom { get; set; }

        public int? MaDV { get; set; }

        public int? NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        public virtual DV DV { get; set; }

        public virtual Users Users { get; set; }
    }
}
