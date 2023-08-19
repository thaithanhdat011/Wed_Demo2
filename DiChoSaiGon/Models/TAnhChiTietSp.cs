using System;
using System.Collections.Generic;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class TAnhChiTietSp
    {
        public string MaChiTietSp { get; set; }
        public string TenFileAnh { get; set; }
        public short? ViTri { get; set; }

        public virtual TChiTietSanPham MaChiTietSpNavigation { get; set; }
    }
}
