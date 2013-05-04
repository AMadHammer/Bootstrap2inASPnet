using System.Web;
using System.Web.Optimization;

namespace Working_Example
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            //Bootstrap
            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include(
            "~/Content/Bootstrap.min.css",
            "~/content/bootstrap.css",
            "~/Content/Bootstrap-responsive.css"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap-responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include( 
                                                        "~/Scripts/jquery-{version}.js", 
                                                        "~/Scripts/bootstrap.js"));

        }
    }
}