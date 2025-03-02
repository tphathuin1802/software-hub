using ObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienConnector:SQLConnector
    {
        public NhanVien DangNhap(string email,string password)
        {
            string sql = " select * from NhanVien " +
                         " where email='" + email + "' and password='" + password + "'";
            SqlDataReader reader = Query(sql);
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                string ma=reader.GetString(1);
                string ten=reader.GetString(2);
                //string email=reader.GetString(3);
                //string matkhau=reader.GetString(4);
                int status=reader.GetInt32(5);
                NhanVien loginNV=new NhanVien();
                loginNV.Id = id;
                loginNV.MaNhanVien= ma;
                loginNV.TenNhanVien= ten;
                loginNV.Email = email;
                loginNV.Password = password;
                loginNV.IsDeleted = status;
                reader.Close();
                return loginNV;
            }
            reader.Close();
            return null;
        }
        public bool DoiMatKhau(NhanVien nv)
        {
            string sql = "update NhanVien set Password='"+nv.Password+"' where id="+nv.Id;
            int ret=NonQuery(sql);
            return ret > 0;//>0 là True-->thành công
        }
        public List<NhanVien> LayToanBoNhanVien()
        {
            List<NhanVien> dsnv = new List<NhanVien>();
            string sql = "select * from NhanVien";

            SqlDataReader reader = Query(sql);
            while (reader.Read())
            {
                int id=reader.GetInt32(0);
                string ma = reader.GetString(1);
                string ten = reader.GetString(2);
                string email = reader.GetString(3);
                string password= reader.GetString(4);
                int isdeleted= reader.GetInt32(5);

                NhanVien nv=new NhanVien();
                nv.Id = id;
                nv.MaNhanVien = ma;
                nv.TenNhanVien= ten;
                nv.Email = email;
                nv.Password = password;
                nv.IsDeleted = isdeleted;

                dsnv.Add(nv);
            }
            reader.Close();
            return dsnv;
        }
        public bool KichHoatLaiNhanVien(NhanVien nv)
        {
            string sql = "update NhanVien set IsDeleted=0 where id=" + nv.Id;
            int ret = NonQuery(sql);
            return ret > 0;//>0 là True-->thành công
        }
        public NhanVien XemChiTiet(int id)
        {
            string sql = "select * from NhanVien where Id="+id+" and IsDeleted=0";
            SqlDataReader reader = Query(sql);
            if (reader.Read())
            {
                
                string ma = reader.GetString(1);
                string ten = reader.GetString(2);
                string email=reader.GetString(3);
                string matkhau=reader.GetString(4);
                int status = reader.GetInt32(5);
                NhanVien loginNV = new NhanVien();
                loginNV.Id = id;
                loginNV.MaNhanVien = ma;
                loginNV.TenNhanVien = ten;
                loginNV.Email = email;
                loginNV.Password = matkhau;
                loginNV.IsDeleted = status;
                reader.Close();
                return loginNV;
            }
            reader.Close();
            return null;
        }
        public bool ThemMoiNhanVien(NhanVien nv)
        {
            string sql = "insert NhanVien(MaNhanVien,TenNhanVien,Email,Password,IsDeleted) " +
                "values('"+nv.MaNhanVien+"',N'"+nv.TenNhanVien+"','"+nv.Email+"','"+nv.Password+"',"+nv.IsDeleted+") ";
            int kq=NonQuery(sql);
            return kq > 0;
        }
    }
}
