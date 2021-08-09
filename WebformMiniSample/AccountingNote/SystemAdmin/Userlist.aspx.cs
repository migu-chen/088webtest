using AccountingNote.DBsource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountingNote.SystemAdmin
{
    public partial class Userlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string account = "Admin";//假設有帳戶
           var dr1 = UserInfoManager.GetUserInfoListtest(account);
                      
           var dt = AccountingManager.GetAccounttingList(dr1["ID"].ToString());
                      
            this.GridView1.DataSource = dt;
          this.GridView1.DataBind();
        }
    }
}