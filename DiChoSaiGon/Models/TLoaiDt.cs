using System;
using System.Collections.Generic;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class TLoaiDt
    {
        public TLoaiDt()
        {
            TDanhMucSps = new HashSet<TDanhMucSp>();
        }

        public string MaDt { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<TDanhMucSp> TDanhMucSps { get; set; }
    }
}
