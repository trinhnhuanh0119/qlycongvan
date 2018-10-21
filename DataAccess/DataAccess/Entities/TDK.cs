namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TDK")]
    public partial class TDK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TDK()
        {
            CV_Den = new HashSet<CV_Den>();
            CV_Di = new HashSet<CV_Di>();
        }

        public int Id { get; set; }

        [StringLength(500)]
        public string DuongDan { get; set; }

        [StringLength(255)]
        public string Ten { get; set; }

        public byte? Loai { get; set; }

        public int? KichThuoc { get; set; }

        public int? MaVB { get; set; }

        public int? NgUpload { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_Den> CV_Den { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_Di> CV_Di { get; set; }

        public virtual Users Users { get; set; }
    }
}
