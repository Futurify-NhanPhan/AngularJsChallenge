using System.Web;
using System.Web.Optimization;

namespace AngularJsChallenge
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/main").Include(
                       "~/Scripts/jquery-2.1.1.js",
                       "~/Scripts/bootstrap.min.js",                       
                       "~/Scripts/angular.min.js"
                       ));

            bundles.Add(new StyleBundle("~/Styles/main").Include(
                        "~/Styles/bootstrap.css"                      
                        ));
            BundleTable.EnableOptimizations = false;
            bundles.IgnoreList.Clear();
        }
    }
}