namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NNVB")]
    public partial class NNVB
    {
        public int Id { get; set; }

        [StringLength(400)]
        public string Ten { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Sdt { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }
    }
}
