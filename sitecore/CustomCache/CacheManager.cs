namespace Sitecore.Custom
{
    public static class CacheManager
    {
        private static readonly MyCustomCache Cache;
 
        static CacheManager()
        {
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