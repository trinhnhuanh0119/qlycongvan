using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class FileVb
    {
        public int Id { get; set; }
        public int? VanBanId { get; set; }
        public string TenFileVb { get; set; }

        public VanBan VanBan { get; set; }
    }
}
