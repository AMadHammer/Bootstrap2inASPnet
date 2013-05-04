using System.Web;
using System.Web.Optimization;

namespace Resume_Builder
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include(
            "~/Content/Bootstrap.min.css",
            "~/content/bootstrap.css",
            "~/Content/Bootstrap-responsive.css"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/Bootstrap").Include(
                        "~/Scripts/jquery-1.*",
                        "~/Scripts/Bootstrap.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
        }
    }
}