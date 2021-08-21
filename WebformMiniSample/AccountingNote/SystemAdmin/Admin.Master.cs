using AccountingNote.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountingNote.SystemAdmin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Authmanager.IsLogined())
            {
                Response.Redirect("/Login.aspx");
                return;
            }

            var currentUser = Authmanager.GetCurrentUser();

            if (currentUser == null)
            {
                //this.Session["UserLoginInfo"] = null;
                Response.Redirect("/Login.aspx");
                return;
            }
        }
    }
}