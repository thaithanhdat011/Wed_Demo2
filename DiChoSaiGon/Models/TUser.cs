using System;
using System.Collections.Generic;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class TUser
    {
        public TUser()
        {
            TKhachHangs = new HashSet<TKhachHang>();
            TNhanViens = new HashSet<TNhanVien>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public byte? LoaiUser { get; set; }

        public virtual ICollection<TKhachHang> TKhachHangs { get; set; }
        public virtual ICollection<TNhanVien> TNhanViens { get; set; }
    }
}
