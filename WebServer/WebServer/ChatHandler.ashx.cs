using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer
{
    /// <summary>
    /// Сводное описание для ChatHandler
    /// </summary>
    public class ChatHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Привет всем!");
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