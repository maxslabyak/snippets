namespace Sitecore.Custom
{
    public static class CacheManager
    {
        private static readonly MyCustomCache Cache;
 
        static CacheManager()
        {
            /* the size can be defined as needed as long as it's 
            // properly parsed out by StringUtil.ParseSizeString()
            // You should be able to see this "MyCustomCache" here:
            // http://{yoursitecoreinstall}/sitecore/admin/cache.aspx
            */
            Cache = new MyCustomCache("MyCustomCache",
                     StringUtil.ParseSizeString("10KB"));
        }
 
        public static string GetCache(string key)
        {
            return Cache.GetString(key);
        }
 
        public static void SetCache(string key,string value)
        {
            Cache.SetString(key, value);
        }
    }
}
