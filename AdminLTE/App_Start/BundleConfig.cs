using System.Web;
using System.Web.Optimization;

namespace AdminLTE
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/respond.js",
                      "~/Assets/plugins/jQuery/jQuery-2.1.4.min.js",
                      "~/Assets/bootstrap/js/bootstrap.min.js",
                      "~/Assets/plugins/slimScroll/jquery.slimscroll.min.js",
                      "~/Assets/plugins/fastclick/fastclick.min.js",
                      "~/Assets/js/app.min.js",
                       "~/Assets/js/demo.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Assets/bootstrap/css/bootstrap.min.css",
                      "~/Assets/css/font-awesome.css",
                      "~/Assets/css/ionicons.css",
                      "~/Assets/css/AdminLTE.min.css",
                      "~/Assets/css/skins/_all-skins.min.css",
                      "~/Assets/css/Customcss.css"
                      ));
        }
    }
}
