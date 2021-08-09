using AccountingNote.auth;
using AccountingNote.DBsource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountingNote
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["UserLOgInfo"] != null)
            {
              this.plcLogin.Visible = false;
               Response.Redirect("/SystemAdmin/UserInfo.aspx");
            }
            else
            {
                this.plcLogin.Visible = true;
            }
         }
            
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            //String db_acct = "admin";
            //String db_apwd = "12345";

            string inp_acct = this.txtaccount.Text;
            string inp_pwd = this.txtPWD.Text;
           

            string msg;
            if (!Authmanager.TryLogin(inp_acct, inp_pwd, out msg))
            {
                this.ItlMsg.Text= msg;
                return;
            }

            Response.Redirect("/SystemAdmin/UserInfo.aspx");
          
        }
       
    }
}