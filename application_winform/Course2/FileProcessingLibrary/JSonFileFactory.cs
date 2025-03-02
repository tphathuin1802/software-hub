using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Encodings.Web;
using System.Text.Unicode;
namespace FileProcessingLibrary
{
    public class JSonFileFactory
    {
        public bool SaveData(object data, string path)
        {
            try
            {
                var options = new JsonSerializerOptions 
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All, UnicodeRanges.All),
                    WriteIndented = true 
                };
                string jsonString = JsonSerializer.Serialize(data, options);                
                File.WriteAllText(path, jsonString);                
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return false;
        }
        public object ReadData<T>(string path) 
        {
            try
            {
                string jsonString = File.ReadAllText(path);
                object data = JsonSerializer.Deserialize<T>(jsonString);
                return data;
            }
            catch (Exception e) { 
                Console.WriteLine(e.ToString());
            }
            return null;
        }
    }
}
