using System;
using System.Collections.Generic;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class TAnhSp
    {
        public string MaSp { get; set; }
        public string TenFileAnh { get; set; }
        public short? ViTri { get; set; }

        public virtual TDanhMucSp MaSpNavigation { get; set; }
    }
}
