using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace FileProcessingLibrary
{
    public class BinaryFileFactory
    {
        /// <summary>
        /// Hàm này để lưu đối tượng bất kỳ xuống ổ cứng
        /// </summary>
        /// <param name="data">Đối tượng muốn lưu</param>
        /// <param name="path">Nơi lưu trữ</param>
        /// <returns>trả về True nếu lưu thành công, False nếu thất bại</returns>
        public bool SaveData(object data,string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, data);
                fs.Close();
                return true;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());    
            }
            return false;
        }
        public object ReadData(string path)
        {
            try
            {
                FileStream fs=new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data=bf.Deserialize(fs);
                fs.Close();
                return data;
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.ToString() );
            }
            return null;
        }
    }
}
