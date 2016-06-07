using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Xml;
using System.Data;

namespace TestInter
{
    /// <summary>
    /// Start 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
     [System.Web.Script.Services.ScriptService]
    public class Start : System.Web.Services.WebService
    {

        [WebMethod]
        public string DetailBrowser(out string info, string XTID = "", string FKEY = "")//
        {
            string s = "";
            if (XTID != "200")
            {
                s = "传输安全代码出错，请重新传输";
                info = "安全码错误";
            }
            else
            {
                s = OpenDB(FKEY);
                info = "ok";
            }
            //string res = OpenDB(FKEY);
            //return res;
            return s;
        }
        public static string OpenDB(string Id)
        {
            string str = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=localhost;user id=sa;password=123456; database=Test";
            //"data source=localhost;initial catalog=Test;user id =sa;password=123456";
            conn.Open();
            #region
            //获取条数
            //string sql = "select count(*) from Study where ID=" + Id;
            //SqlCommand commnad = new SqlCommand(sql, conn);
            //int num = (int)commnad.ExecuteScalar();
            #endregion

            string sql = "select FileName,BeginDate,EndDate,Img from Study where ID=" + Id;
            SqlCommand commnad = new SqlCommand(sql, conn);
            SqlDataReader rd = commnad.ExecuteReader();
            
            //xml格式数据
            XmlDocument doc = new XmlDocument();
            //XmlDeclaration xmldecl;
            //xmldecl = doc.CreateXmlDeclaration("1.0", "gb2312", null);
            //doc.AppendChild(xmldecl);
            //加入根元素
            doc.AppendChild(doc.CreateElement("", "DocumentElement", ""));
            while (rd.Read())
            {
                
                XmlNode root = doc.SelectSingleNode("DocumentElement");
                XmlElement element = doc.CreateElement("learnInfo");
                XmlElement element1 = doc.CreateElement("FileName");
                element1.InnerText = rd[0].ToString();
                element.AppendChild(element1);
                XmlElement element2 = doc.CreateElement("BeginDate");
                element2.InnerText = rd[1].ToString();
                element.AppendChild(element2);
                XmlElement element3 = doc.CreateElement("EndDate");
                element3.InnerText = rd[2].ToString();
                element.AppendChild(element3);
                XmlElement element4 = doc.CreateElement("Pic");
                element4.InnerText = rd[3].ToString();
                element.AppendChild(element4);
                root.AppendChild(element);
            }
            str = doc.InnerXml;
           
            return str;
        }

  
    }
}
