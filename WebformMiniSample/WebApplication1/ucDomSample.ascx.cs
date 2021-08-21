using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ucDomSample : System.Web.UI.UserControl
    {
        public Image  MyImage { get { return this.Image1; } }
        //建立屬性

        public  Image GetImage1()
        {
          return this.Image1;
        }
           

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.Button1.Visible = false;
            //this.Label1.Text = "hell  png";
            //Control ctl = this.FindControl("PlaceHolder3");

            //if (ctl != null)
            //{
            //    //ctl.Visible = false;
            //    var firstcontrol = ctl.Controls[0];
            //    if (firstcontrol  != null)
            //    {
            //        firstcontrol.Visible = false;
            //    }
            var Itl = this.FindControl("Literal1") as Literal;//重要關念

            if (Itl != null)
            {
                //Itl.Visible = false;
                Itl.Text = "Changed by page-log";
            }

            //}
            //this.Controls[0].Controls[1].Controls[0].Visible = false;//
            //this.WriteControlID(this);//this.PlaceHolder2
         }
            private void WriteControlID(Control ctl)
            {
                //if (ctl == null)
                //    return;
                //Response.Write(ctl.ID + "<br />");

                //if (ctl.Controls.Count == 0)
                //    return;
                //foreach (Control item in ctl.Controls)
                //{
                //    this.WriteControlID(item);
                //}
            }

        
    }
}