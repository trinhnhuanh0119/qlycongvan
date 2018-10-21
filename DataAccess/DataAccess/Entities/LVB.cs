namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LVB")]
    public partial class LVB
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Ten { get; set; }
    }
}
