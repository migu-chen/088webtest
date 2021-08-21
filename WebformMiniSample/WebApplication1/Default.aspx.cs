using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Main mainMaster = this.Master as Main;
            mainMaster.MyTitle = "預設頁";
            mainMaster.SetPageCaption("預設頁");

            //this.ucControl1.SetText("第一個 uc");
            this.ucControl2.SetText("第二個 uc");
            this.ucControl3.SetText("第三個 uc");
           
        }

    }
}