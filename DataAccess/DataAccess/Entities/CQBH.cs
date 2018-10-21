namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CQBH")]
    public partial class CQBH
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Ten { get; set; }

        public int? IdCCQBH { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Sdt { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(10)]
        public string TenTat { get; set; }

        public virtual CCQBH CCQBH { get; set; }
    }
}
