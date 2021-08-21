using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Main : System.Web.UI.MasterPage
    {
        public string MyTitle { get; set; } = string.Empty;
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("MasterPage-Page_Initt<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("MasterPage-Page_Load<br/>");
        }


        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("MasterPage-Page_PreRender<br/>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.ItIMsg.Text = this.txtEmail.Text;
            Response.Write("MasterPage-Button1_Clickt<br/>");
        }

        public void SetPageCaption(string title)
        {
            if(!string .IsNullOrWhiteSpace (title ))
                this.ItlCaption.Text = title;
        }
        
    }
}