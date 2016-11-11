using System.Web.Optimization;

namespace UniversalProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/easyUI").Include(
                      "~/scripts/jquery.easyui-1.4.5.min.js",
                      "~/scripts/easyloader.js"));
            bundles.Add(new ScriptBundle("~/bundles/universal").Include(
                      "~/scripts/universal/user.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/themes/default/easyui.css",
                      "~/Content/themes/color.css",
                      "~/Content/themes/icon.css"));
        }
    }
}
