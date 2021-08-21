using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{  
    public partial class WebForm1 : System.Web.UI.Page
    {  
        public string StringObject { get; set; }
        public class Temp {
            public string Name { get; set; }
            public int Age { get; set; }
            public int ForJSCoffecion { get; set; } = 110;
            public int ForJSBase { get; set; } = 5;
            public int ForJSInt { get; set; } = 500;
            public bool ForJSBool { get; set; } = true;
            public string ForJSString { get; set; } = "Hello World!";

           
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Temp temp = new Temp()
            {
                Name = "tim",
                Age = 20
            };

            string jsonText = 
                Newtonsoft.Json.JsonConvert.SerializeObject(temp);
            this.StringObject = jsonText;
        }
    }
}