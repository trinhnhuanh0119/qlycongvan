namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NBH")]
    public partial class NBH
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string DiaDanh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBH { get; set; }
    }
}
