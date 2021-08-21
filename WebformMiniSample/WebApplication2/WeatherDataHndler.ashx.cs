using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    /// <summary>
    /// WeatherDataHndler 的摘要描述
    /// </summary>
    public class WeatherDataHndler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string acc = context.Request.QueryString["Password"];
            string pwd = context.Request.Form["Password"];

            context.Response.ContentType = "application/json";
            //context.Response.Write( @"{""name:"": ""太魯閣國家公園太魯閣遊客中心 "", ""T"": 20,"Pop"":28 }");
            if(acc == "MOudou" && pwd == "1234567")
            {     
              WeatherDataModel model = WeatherDataReader.ReadData();
              string jsonText = Newtonsoft.Json.JsonConvert.SerializeObject(model);
              context.Response.Write(jsonText);
            }
            else
            {
                context.Response.StatusCode = 401 ;
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}