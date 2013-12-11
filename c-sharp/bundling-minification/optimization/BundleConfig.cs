using System.Web.Optimization;

namespace Image0.Optimization
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254726
        public static void RegisterBundles()
        {
            var js = new ScriptBundle("~/bundles/js");
            
            js.Include("~/js/jquery/jquery-1.9.js");   
            js.Include("~/js/maxs-functions.js");
           
            var css = new StyleBundle("~/bundles/css");
            css.Include("~/css/styles.css");
            
            
            BundleTable.Bundles.Add(js);
            BundleTable.Bundles.Add(css);

            
        }
    }
}