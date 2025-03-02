using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModel;
namespace DAL
{
    public class DanhMucConnector:SQLConnector
    {
        public List<DanhMuc> LayToanBoDanhMuc()
        {
            List<DanhMuc>dsdm = new List<DanhMuc>();
            string sql = "select * from DanhMuc ";
            SqlDataReader reader=Query(sql);
            while (reader.Read())//di chuyển đầu đọc tới từng dòng dữ liệu
            { 
                string madm=reader.GetString(0);
                string tendm=reader.GetString(1);
                DanhMuc dm=new DanhMuc();
                dm.MaDanhMuc=madm;
                dm.TenDanhMuc = tendm;
                dsdm.Add(dm);
            }
            return dsdm;
        }
    }
}
