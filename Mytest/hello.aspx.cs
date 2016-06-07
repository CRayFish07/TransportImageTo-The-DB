using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace Mytest
{
    public partial class hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
        }
      
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            myservice a = new myservice();
            Button1.Text = a.HelloWorld();
        }
        
       
    }
}