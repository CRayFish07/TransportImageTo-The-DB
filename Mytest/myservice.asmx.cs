using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Mytest
{
    /// <summary>
    /// myservice 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
     [System.Web.Script.Services.ScriptService]
    public class myservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "我爱你中国";
        }
        [WebMethod]
        public List<Student> Hiworld()
        {
            List<Student> students = new List<Student>(){
                new Student{Name="xiaoming",age=32},
                new Student{Name="wangli",age=20},
                new Student{Name="haha",age=32},
                new Student{Name="woaini",age=24},
                new Student{Name="henan",age=42},
                new Student{Name="xiaozhao",age=55}
            };
            
            return students;
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string Nation { get; set; }
    }
}
