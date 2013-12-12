A simple implementation of Sitecore's CustomCache,
giving you the ability to extend it for your use.

CustomCache.cs - Class definition for CustomCache. Needs to be inherited from Sitecore.Caching.CustomCache, as this class cannot be instantiated directly. 

CacheManager.cs - Static class that manages the instantiation of the CustomCache class, defining the size and name of the cache, along with the get/set methods.

MyClass - example of usage
