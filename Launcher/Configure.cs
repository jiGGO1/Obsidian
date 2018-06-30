using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using LitJson;
using Newtonsoft.Json;

namespace Obsidian.Launcher
{
    /// <summary>
    /// josn数据操作类
    /// </summary>
    public class Configure
    {
        /// <summary>
        /// 初始化创建josn字符串
        /// </summary>
        /// <returns>返回josn字符串</returns>
        public static string ToJson()
        {
            ConfigureFile configurefile = new ConfigureFile();
            List<ConfigureFile> listconfigurefile = new List<ConfigureFile>();
            listconfigurefile.Add(configurefile);
            StringBuilder strjson = new StringBuilder(JsonMapper.ToJson(listconfigurefile));
            strjson = strjson.Replace("[", "");
            strjson = strjson.Replace("]", "");
            //strjson = strjson.Replace("{", "{\n\t");
            //strjson = strjson.Replace(",", ",\n\t");
            //strjson = strjson.Insert(strjson.ToString().LastIndexOf("}"), "}\n");
            MessageBox.Show(ConvertJsonString(strjson.ToString()));
            return ConvertJsonString(strjson.ToString());
        }

        public static string ToJson(ConfigureFile configurefile)
        {
            List<ConfigureFile> listconfigurefile = new List<ConfigureFile>();
            listconfigurefile.Add(configurefile);
            StringBuilder strjson = new StringBuilder(JsonMapper.ToJson(listconfigurefile));
            strjson = strjson.Replace("[", "");
            strjson = strjson.Replace("]", "");
            return ConvertJsonString(strjson.ToString());
        }

        /// <summary>
        /// 生成josn文件
        /// </summary>
        /// <param name="str">josn字符串</param>
        /// <returns>返回是否生成成功</returns>
        public bool WriteFile(string str)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Obsidian.json", FileMode.Create);//创建写入文件 
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));
            bool writefilebool = false;
            try
            {
                sw.WriteLine(str);
                writefilebool = true;
            }
            catch (IOException e)
            {
                writefilebool = false;
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
            return writefilebool;
        }

        /// <summary>
        /// 格式化json字符串  
        /// </summary>
        /// <param name="str">josn字符串</param>
        /// <returns>返回格式化josn字符串</returns>
        private static string ConvertJsonString(string str)
        {
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }  


        /// <summary>
        /// litjosn解析字符串对应类
        /// </summary>
        /// <returns>返回ConfigureFile对象</returns>
        public static ConfigureFile ReadJosn()
        {
            ConfigureFile configurefile = JsonMapper.ToObject<ConfigureFile>(ReadFile());
            return configurefile;
        }

        /// <summary>
        /// 读取文件返回josn字符串
        /// </summary>
        /// <returns>返回josn字符串</returns>
        private static string ReadFile()
        {
            string strfile = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + @"\Obsidian.json");
            return strfile;
        }
    }
}
