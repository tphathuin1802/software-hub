using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class NhanVien
    {
        public int Id{ get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string Email   { get; set; }
        public string Password { get; set; }
        public int IsDeleted   { get; set; }
    }
}
