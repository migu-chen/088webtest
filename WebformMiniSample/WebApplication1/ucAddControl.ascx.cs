using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ucAddControl : System.Web.UI.UserControl
    {
        protected void Page_Init(object sender, EventArgs e)
        {
         }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["ControlList"] != null)
            {
                this.AddControls();
            }

        }

        private void AddControls()
        {
            Label Ib1 = new Label();
            Ib1.ID = "Labell";
            Ib1.Text = "test;";

            TextBox txt = new TextBox();
            txt.ID = "txt1";
            txt.Text = "test1";

            Button btn = new Button();
            btn.ID = "Button2";
            btn.Text = "Chick";
            btn.Click += Btn_Click;

            this.Controls.Add(Ib1);
            this.Controls.Add(txt);
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var txt= this.FindControl("txt1") as TextBox;
            Response.Write(txt.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.AddControls();
            this.Session["ControlList"] = new string[] {"Labell","txt1","Button1" };
        }


    }
}