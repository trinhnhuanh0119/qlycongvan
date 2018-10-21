namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SVB")]
    public partial class SVB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SVB()
        {
            CV_Den = new HashSet<CV_Den>();
            CV_Den1 = new HashSet<CV_Den>();
            CV_Di = new HashSet<CV_Di>();
        }

        public int Id { get; set; }

        [StringLength(10)]
        public string SoVB { get; set; }

        [StringLength(30)]
        public string KyHieu { get; set; }

        public bool? LVB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_Den> CV_Den { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_Den> CV_Den1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_Di> CV_Di { get; set; }
    }
}
