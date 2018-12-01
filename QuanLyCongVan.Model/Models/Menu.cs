using System;
using System.Collections.Generic;

namespace QuanLyCongVan.Model.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int? ParentId { get; set; }
        public bool? TrangThai { get; set; }
        public string CSS { get; set; }
        public string LinkView { get; set; }
        public string MaCapCqbh { get; set; }
    }
}
