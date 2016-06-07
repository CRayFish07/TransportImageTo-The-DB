using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string XTID = "870E8CB3-1357-476F-81E4-7B54883463B5";
            string JYXX = "<?xml version=\"1.0\" encoding=\"GBK\"?><DATAPACKET><METADATA><FIELDS><FIELD attrname=\"\" fieldtype=\"string\" WIDTH=\"20\"/><FIELD attrname=\"周拉太\" fieldtype=\"string\" WIDTH=\"20\"/></FIELDS></METADATA></DATAPACKET>";
            //<FIELD attrname=\"632521197811133035\" fieldtype=\"string\" WIDTH=\"20\"/>
            Edu.TPEduInfoTransfer du = new Edu.TPEduInfoTransfer();
            string res= du.SendContinueEdu(XTID,JYXX);
            TextBox3.Text = res;
        }
    }
}