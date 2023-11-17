using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank_Management
{
    
        public class NoCacheAttribute : ActionFilterAttribute
        {
            public override void OnResultExecuted(ResultExecutedContext filterContext)
            {
                var response = filterContext.HttpContext.Response;
                response.Cache.SetCacheability(HttpCacheability.NoCache);
                response.Cache.SetNoStore();
                base.OnResultExecuted(filterContext);
            }
        }
    
}