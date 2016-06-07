using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestInter
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string info;
            string Code = TextBox1.Text;
            string Num = TextBox2.Text;
            Start t1 = new Start();
            TextBox3.Text = t1.DetailBrowser(out info, Code, Num);
            TextBox4.Text = info;
        }
    }
}