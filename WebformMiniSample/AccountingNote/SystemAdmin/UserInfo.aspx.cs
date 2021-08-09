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

                string account = this.Session["UserLoginInfo"] as string;
                //DataRow dr = UserInfoManager.GetUserInfoByAccount( account );
                DataRow dr = UserInfoManager.GetUserInfoListtest(account);
                DataRow dr1 = dr;


                if (dr1 == null)
                {
                    this.Session["UserLoginInfo"] = null;
                    Response.Redirect("/Login.aspx");
                    return;
                }

                this.ItAccount.Text = dr1["Account"].ToString();
                this.ItEmail.Text = dr1["Email"].ToString();
                this.Itname.Text = dr1["Name"].ToString();
            }
        }


        protected void btnLogout_Click(object sender, EventArgs e)
        {
            this.Session["UserLoginInfo"] = null;
            Response.Redirect("/Login.aspx");
        }
    }
}