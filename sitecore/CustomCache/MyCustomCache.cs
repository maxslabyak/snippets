namespace Sitecore.Custom
{
    public class MyCustomCache : Caching.CustomCache
    {
        public MyCustomCache(string name, long maxSize) : base(name, maxSize)
        {
 
        }
 
        new public void SetString(string key, string value)
        {
            base.SetString(key, value);
        }
 
        new public string GetString(string key)
        {
            return base.GetString(key);
        }
    }
}