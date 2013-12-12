A simple implementation of Sitecore's CustomCache,
giving you the ability to extend it for your use.

<b>CustomCache.cs</b> - Class definition for CustomCache. Needs to be inherited from Sitecore.Caching.CustomCache, as this class cannot be instantiated directly. 

<b>CacheManager.cs</b> - Static class that manages the instantiation of the CustomCache class, defining the size and name of the cache, along with the get/set methods.

<b>MyClass.cs</b> - example of usage.
