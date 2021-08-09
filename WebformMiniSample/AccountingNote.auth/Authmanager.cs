using AccountingNote.DBsource;
using System;
using System.Collections.Generic;
using System.Data;
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
            if(HttpContext.Current.Session["UserLoginInfo"] != null)
                return true;
            else
                return false;
        }
        //如果沒有登錄回傳null，否則取得已登入使用者 資訊
        //AccountingNote.auth.UserInfnModel
        public static UserInfoModel GetCurrentUser()
        {
            string account = HttpContext.Current.Session["UserLoginInfo"] as string;
            if (account == null)
                return null;

            DataRow dr = UserInfoManager.GetUserInfoListtest(account);
            //return dr;
            if (dr == null)
            {
                HttpContext.Current.Session["UserLoginInfo"] = null;
                return null;
            }

            UserInfoModel model = new UserInfnModel();
            model.ID = dr["ID"].ToString();
            model.Account = dr["Account"].ToString();
            model.Name = dr["Name"].ToString();
            model.Email = dr["Email"].ToString();

            return model;
        }

        public static void logout()
        {
            HttpContext.Current .Session["UserLoginInfo"] = null;
        }

    }
}
