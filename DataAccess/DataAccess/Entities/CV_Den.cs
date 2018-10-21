namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CV_Den
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CV_Den()
        {
            CV_Den1 = new HashSet<CV_Den>();
            CV_Di = new HashSet<CV_Di>();
        }

        public int Id { get; set; }

        public int? SoVB { get; set; }

        [StringLength(50)]
        public string SoHieu { get; set; }

        [StringLength(250)]
        public string Noigui { get; set; }

        public int? SVB { get; set; }

        [StringLength(300)]
        public string PTGui { get; set; }

        public bool? LVB { get; set; }

        public int? DoMat { get; set; }

        public int? DoKhan { get; set; }

        public int? NPT { get; set; }

        public int? NST { get; set; }

        public int? DVKy { get; set; }

        public int? NKy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NBH { get; set; }

        public int? TLcVB { get; set; }

        [StringLength(500)]
        public string TrichY { get; set; }

        public int? DinhKem { get; set; }

        public virtual TDK TDK { get; set; }

        public virtual DoKhan DoKhan1 { get; set; }

        public virtual DoMat DoMat1 { get; set; }

        public virtual DV DV { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        public virtual Users Users2 { get; set; }

        public virtual SVB SVB1 { get; set; }

        public virtual SVB SVB2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_Den> CV_Den1 { get; set; }

        public virtual CV_Den CV_Den2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_Di> CV_Di { get; set; }
    }
}
