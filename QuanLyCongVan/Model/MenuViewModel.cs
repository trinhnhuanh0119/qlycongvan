using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCongVan.Model
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public bool? TrangThai { get; set; }
        public string CSS { get; set; }
        public string LinkView { get; set; }
        public List<MenuViewModel> SubMenu { get; set; }
    }
}
