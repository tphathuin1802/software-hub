using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    [Serializable]
    public class SanPham
    {
        //POCO
        public string Ma {  get; set; }
        public string Ten { get; set; }
        public int SoLuong {  get; set; }
        public double Gia { get; set; } 
        public string MaDM {  get; set; }   
    }
}
