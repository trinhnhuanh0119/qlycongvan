namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuuTru")]
    public partial class LuuTru
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string TD_CongVan { get; set; }

        public int? KhoLT { get; set; }

        public int? Phong { get; set; }

        public int? CapSo { get; set; }

        public int? LoaiBQ { get; set; }

        public virtual CapSo CapSo1 { get; set; }

        public virtual KhoLuuTru KhoLuuTru { get; set; }

        public virtual LoaiBQ LoaiBQ1 { get; set; }

        public virtual Phong Phong1 { get; set; }
    }
}
