using System;
using System.Collections.Generic;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class TKichThuoc
    {
        public TKichThuoc()
        {
            TChiTietSanPhams = new HashSet<TChiTietSanPham>();
        }

        public string MaKichThuoc { get; set; }
        public string KichThuoc { get; set; }

        public virtual ICollection<TChiTietSanPham> TChiTietSanPhams { get; set; }
    }
}
