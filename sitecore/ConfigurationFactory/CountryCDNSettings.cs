using System;
using System.Web;
using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.Sites;
using Sitecore.Web;
using Sitecore.StringExtensions;

namespace Image0.CDN
{
    public class CountryCdnSettings
    {
        public bool Enabled { get; set; }
        public string LiveDatabase { get; set; }
        public string CdnPath { get; set; }
        
        protected CountryCdnSettings() { }

        // websiteConfigKey - site note under <sites> - e.g. website-us, website-uk, etc.
        public static CountryCdnSettings Create(string websiteConfigKey)
        {
            var settings = new CountryCdnSettings();
            
            //with Reflection helper, this object's properties will automagically get set
            ReflectionHelper.SetPropertiesFromConfig(settings, "CdnSettings/" + websiteConfigKey, new string[0]);
            
            return settings;
            
        }
    }
}
