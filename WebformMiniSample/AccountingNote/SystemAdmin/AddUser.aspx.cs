using AccountingNote.DBsource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountingNote
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = this.tid.Text;
            string account = this.taccount.Text;
            string PWD = this.tPWD.Text;
            string name = this.tname.Text;
            string Email = this.tEmail.Text;

            this.aid.Text = id;
            this.aaccount.Text = account ;
            this.aPWD.Text  = PWD ;
            this.laname.Text = name ;
            this.aEmail.Text = Email ;

            //UserInfoManager.InsertIntoData( account, PWD, name, Email);

            
        }
    }
}