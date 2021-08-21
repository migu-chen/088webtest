using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("WebForm5-Page_Init<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("WebForm5-Page_Load<br/>");
        }


        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("WebForm5-PreRender<br/>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //this.ItIMsg.Text = this.txtEmail.Text;
            Response.Write("WebForm5_Button1_Clickt<br/>");
        }

       

    }
 
}