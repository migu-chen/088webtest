using System;
using System.Windows;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        public int ForJSInt { get; set; } = 500;
        public bool ForJSBool{ get; set;} = true;
        public string ForJSString { get; set; } = "Hello World!"; 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.hf2.Value = "Test Message!";
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
           // this.Ib1name.Text = this.txt1.Text;
            this.Ib1name.Text = this.hf1.Value;
        }
    }
}