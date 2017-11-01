using System.Text;
using System.Web.Mvc;
using SXBIN.DB.DAL;
using SXBIN.Tool;

namespace SXBIN.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginOnPost(LoginOnPostModel obj)
        {
            var result = new DataJsonResult();
            var adminUser= B_AdminUser.Login(obj.UserName, Common.Md5Password(obj.Password));
            if (adminUser==null)
            {
                return Content(JS.GetReBack("对不起，用户名和密码不正确"));
            }
            Session["AdminUser"] = adminUser.Id;
            return RedirectToAction("Index","Home");
        }
    }
    public class JS
    {


        public static string GetReBack(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");
            sb.Append($"alert('{msg}');");
            sb.Append("window.history.go(-1);");
            sb.Append("</script>");
            return sb.ToString();
        }
        public static string GetReUrl(string msg, string url)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");
            sb.Append($"alert('{msg}');");
            sb.Append($"location.href = '{url}';");
            sb.Append("</script>");
            return sb.ToString();
        }
    }
}