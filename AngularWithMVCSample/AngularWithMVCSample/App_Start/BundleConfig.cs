using System.Web.Optimization;

namespace AngularWithMVCSample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/AwesomeAngularMVCApp")
                    .IncludeDirectory("~/Scripts/Controllers", "*.js")
                    .Include("~/Scripts/AngularWithMVCSample.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}