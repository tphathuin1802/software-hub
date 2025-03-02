using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    internal class SanPhamBinhLuan
    {
        public int Id { get; set; }
        public string BinhLuan { get; set; }
        public string MaSanPham { get; set; }
        public DateTime? ThoigianBinhLuan { get; set; }
        
    }
}
