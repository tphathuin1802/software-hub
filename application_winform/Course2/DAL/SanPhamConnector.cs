using ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamConnector:SQLConnector
    {
        public List<SanPham> LayToanBoSanPham()
        {
            List<SanPham>dssp = new List<SanPham>();
            string sql = "select * from SanPham";

            SqlDataReader reader = Query(sql);
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten=reader.GetString(1);
                int soluong=reader.GetInt32(2);
                double gia=reader.GetDouble(3);
                string madm=reader.GetString(4);
                
                SanPham sp=new SanPham();
                sp.Ma = ma;
                sp.Ten = ten;
                sp.SoLuong = soluong;
                sp.Gia = gia;
                sp.MaDM = madm;

                dssp.Add(sp);
            }
            return dssp;
        }
    }
}
