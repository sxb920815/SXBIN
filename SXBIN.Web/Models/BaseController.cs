using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SXBIN.DB.DAL;
using SXBIN.DB.Model;

namespace SXBIN.Web
{
    public class BaseController : Controller
    {
        public AdminUser MyUser;

        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Session["AdminUser"] = 1;
            if (Session["AdminUser"] == null)
            {
                filterContext.Result = new RedirectResult("/Admin/Login/Index");
            }
            else
            {
                var userId = (Guid)Session["AdminUser"];
                MyUser = B_AdminUser.FindById(userId);
            }

            base.OnActionExecuting(filterContext);
        }
    }
}