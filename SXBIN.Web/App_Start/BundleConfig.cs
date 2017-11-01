using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SXBIN.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/admin/js").Include(
                       "~/Resources/Admin/JS/jquery.min.js",
                       "~/Resources/Admin/JS/bootstrap.min.js",
                       "~/Resources/Admin/JS/plugins/metisMenu/jquery.metisMenu.js",
                       "~/Resources/Admin/JS/plugins/slimscroll/jquery.slimscroll.min.js",
                       "~/Resources/Admin/JS/plugins/layer/layer.min.js",
                       "~/Resources/Admin/JS/hplus.js",
                       "~/Resources/Admin/JS/contabs.js",
                       "~/Resources/Admin/JS/plugins/pace/pace.min.js"));

            bundles.Add(new StyleBundle("~/admin/css").Include(
                    "~/Resources/Admin/CSS/bootstrap.min.css",
                    "~/Resources/Admin/CSS/font-awesome.min.css",
                    "~/Resources/Admin/CSS/animate.css",
                    "~/Resources/Admin/CSS/style.css"));

        }
    }
}