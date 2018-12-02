using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCongVan.Repository.Object
{
    public class DoMatTableGridRequest
    {
        public string DoMat { get; set; }
        public string GhiChu { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
