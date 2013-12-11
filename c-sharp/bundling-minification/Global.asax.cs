using System;
using System.Web.Optimization;
using System.Web.Security;

namespace Image0
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Optimization.BundleConfig.RegisterBundles();
        }


        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // disabling bundling because of IE7 issues
            // This example uses Sitecore's IsIE(7) method, 
            // But you are more than welcome to use your own IE detection
            // If you care about IE7 that is...
            if (Sitecore.UIUtil.IsIE(7) && BundleTable.EnableOptimizations)
                BundleTable.EnableOptimizations = false;
            else if (!Sitecore.UIUtil.IsIE(7) && !BundleTable.EnableOptimizations)
                BundleTable.EnableOptimizations = true;
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
