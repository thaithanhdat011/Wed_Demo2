using System;
using System.Collections.Generic;

#nullable disable

namespace DiChoSaiGon.Models
{
    public partial class TChatLieu
    {
        public TChatLieu()
        {
            TDanhMucSps = new HashSet<TDanhMucSp>();
        }

        public string MaChatLieu { get; set; }
        public string ChatLieu { get; set; }

        public virtual ICollection<TDanhMucSp> TDanhMucSps { get; set; }
    }
}
