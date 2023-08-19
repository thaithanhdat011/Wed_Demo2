using System;
using System.Collections.Generic;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class TLoaiSp
    {
        public TLoaiSp()
        {
            TDanhMucSps = new HashSet<TDanhMucSp>();
        }

        public string MaLoai { get; set; }
        public string Loai { get; set; }

        public virtual ICollection<TDanhMucSp> TDanhMucSps { get; set; }
    }
}
