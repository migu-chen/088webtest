using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace AccountingNote.auth
{
    public class Authmanager
    {
        public static bool IsLogined()
        {
            if (System.Web.HttpContext.Current.Session["UserLoginInfo"] == null)
                return false;
            else
                return true;
          

        }

    }
}
