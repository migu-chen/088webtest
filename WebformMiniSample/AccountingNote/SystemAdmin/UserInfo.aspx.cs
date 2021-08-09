using AccountingNote.auth;
using System;
using System.Data;
using UserInfoManager = AccountingNote.DBsource.UserInfoManager;

namespace AccountingNote.SystemAdmin
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
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

                this.ItAccount.Text = currentUser.Account;
                this.ItEmail.Text = currentUser.Email;
                this.Itname.Text = currentUser.Name;
            }
        }


        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //this.Session["UserLoginInfo"] = null;
            Authmanager.logout();
            Response.Redirect("/Login.aspx");
        }
    }
}