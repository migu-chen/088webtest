using AccountingNote.Auth;
using AccountingNote.DBsource;
using System;
using System.Data;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountingNote.SystemAdmin
{
    public partial class AccountingList1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {  // check is logined
           // if (this.Session["UserLoginInfo"] == null)
            if (!Authmanager.IsLogined())
            {
                Response.Redirect("/login.aspx");
                return;
            }
            //string account = this.Session["UserLoginInfo"] as string;
            var currentUser = Authmanager.GetCurrentUser();

            if (currentUser == null)
            {
                Response.Redirect("/login.aspx");
                return;
            }

            var dt = AccountingManager.GetAccounttingList(currentUser.ID);

            if (dt.Rows.Count > 0)
            {
                //int totalPages = this.GetTotalPages(dt);
                var dtPaged = this.GetPagedDataTable(dt);
                this.ucPage2.TotalSize = dt.Rows.Count;
                this.ucPage2.Bind();

                this.gvAccountList.DataSource = dtPaged;
                this.gvAccountList.DataBind();

                this.ucPage2.TotalSize = dt.Rows.Count;//給出總數
                this.ucPage2.Bind();
                
            }
            else
            {
                this.gvAccountList.Visible = false;
                this.plcNodata.Visible = true;
            }
         
        }


        private int GetCurrentPage()
        {
            string pageText = Request.QueryString["Page"];

            if (string.IsNullOrWhiteSpace(pageText))
                return 1;

            int intPage;
            if (!int.TryParse(pageText, out intPage))
                return 1;

            if (intPage <= 0)
                return 1;

            return intPage;
        }


        private DataTable GetPagedDataTable(DataTable dt)
        {
            DataTable dtPaged = dt.Clone();
            //foreach (DataRow dr in dt.Rows )
            //for(var i=0;i < dt.Rows.Count; i++ )
            int pageSize = this.ucPage2.PageSize;
            int startIndex = (this.GetCurrentPage() - 1) * pageSize;
            int endIndex = (this.GetCurrentPage()) * pageSize;
            if (endIndex > dt.Rows.Count)
                endIndex = dt.Rows.Count;
            for (var i = startIndex; i < endIndex; i++)
            {
                DataRow dr = dt.Rows[i];
                var drNew = dtPaged.NewRow();

                foreach(DataColumn dc in dt.Columns)
                {
                     drNew[dc.ColumnName] = dr[dc];
                }
                dtPaged.Rows.Add(drNew);
            }
            
            return dtPaged;
        }

        //public override void VerifyRenderingInServerForm(Control control)
        //{
        //    //處理'GridView' 的控制項 'GridView' 必須置於有 runat=server 的表單標記之中
        //}

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("/SystemAdmin/AccountingDetail.aspx");
        }

        protected void gvAccountingList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            var row = e.Row;

            if(row.RowType == DataControlRowType.DataRow)
            {

            
              //e.Row.DataItem as DataControlRowState;
              // Literal lt4 = row.FindControl("ItActType") as Literal;
               Label lbI = row.FindControl("Ib4ActType") as Label;
                var dr = row.DataItem as DataRowView;
               int actType = dr.Row.Field<int>("ActType");

               if (actType == 0)
                {
                    //lt4.Text = "支出" ;
                    lbI.Text = "支出";
                }
                else
                {
                    //lt4.Text = "收入";
                    lbI.Text = "收入";
                }
                
               if (dr.Row.Field <int>("Amount") > 1500)
                {
                    lbI.ForeColor = Color.Red;
                }
            }
        }
    }
}