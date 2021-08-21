using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountingNote.UserControls
{
    public partial class ucPager : System.Web.UI.UserControl
    {
        //頁面
        public string Url { get; set; }
        //總筆數
        public int TotalSize { get; set; }
        //每頁筆數
        public int PageSize { get; set; }
        //目前頁數
        public int CurrentPage { get; set;}


        protected void Page_Load(object sender, EventArgs e)
        {
           // this.Bind();
        }

        public  void Bind()
        {
            int totalPages = this.GetTotalPages();

            this.ItPager.Text = $"共 {this.TotalSize}筆，共 {totalPages} " +
                $"頁 ,目前在第{this.GetCurrentPage()} 頁 <br />";

            for (var i = 1; i <= totalPages; i++)
            {
                this.ItPager.Text += $"<a " +
                    $"href='{this.Url }?page={i}'>{i}</ a> &nbsp;";
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

        private int GetTotalPages()
        {
            int pages = this.TotalSize / this.PageSize  ;
            if ((this.TotalSize / this.PageSize) > 0)
                pages += 1;

            return pages;

        }

    }
}