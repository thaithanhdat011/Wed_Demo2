using System;
using System.Collections.Generic;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class TChiTietHdb
    {
        public string MaHoaDon { get; set; }
        public string MaChiTietSp { get; set; }
        public int? SoLuongBan { get; set; }
        public decimal? DonGiaBan { get; set; }
        public double? GiamGia { get; set; }
        public string GhiChu { get; set; }

        public virtual TChiTietSanPham MaChiTietSpNavigation { get; set; }
        public virtual THoaDonBan MaHoaDonNavigation { get; set; }
    }
}
