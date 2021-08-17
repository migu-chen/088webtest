using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ucControl2 : System.Web.UI.UserControl
    {
        public string Mytitle { get; set; }
        public enum BColor
        {
            Blue,
            Red,
            Green
        }

        public BColor BackColor { get; set; } = BColor.Red ;

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("ucControe-Page_Init<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("ucControe- Page_Load<br/>");
            if (!string.IsNullOrWhiteSpace(Mytitle))
            {
                this.ItItitle.Text = Mytitle;
                this.imgCover.Alt = Mytitle;
            }
            this.divMain.Style.Add("background-colort<br/>", this.BackColor.ToString());
        }


        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("ucControe-Page_PreRender<br/>");

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    //this.ItIMsg.Text = this.txtEmail.Text;
        //    Response.Write("ucControge-Page_Init");
        //}



        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(Mytitle))
        //    {
        //        this.ItItitle.Text = Mytitle;
        //        this.imgCover.Alt = Mytitle; 
        //    }
        //    this.divMain.Style.Add("background-color", this.BackColor.ToString());
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.ItItitle.Text = "unControlImage_Click";
            this.imgCover.Alt = "unControlImage_Click";
            Response.Write("ucControge Button1_Click");
        }


        public void SetText(string Mytitle)
        {
            if (!string.IsNullOrWhiteSpace(Mytitle))
            {
                this.ItItitle.Text = Mytitle;
                this.imgCover.Alt = Mytitle;
            }

        }
    }
}