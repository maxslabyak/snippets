Sitecore.Configuration.Factory is a very powerful class.

Sitecore configuration files are a great place to store environment-specific settings. Sitecore itself is a horrible place to store environment-specific files, because content gets published from environment to environment and is extremely easy to overwrite settings by mistake.

Configuration files on the other hand are easily managed. All you have to do is dump a .config file in your /App_Config/Include directory and Sitecore will pick it up. 

You can confirm this via http://{yoursite}/sitecore/admin/showconfig.aspx

3 classes make this work.
<ol>
<li><b>ReflectionHelper</b> - This helper class will help store XML nodes into the settings' class properties.</li>
<li><b>CountryCDNSettings</b> - This static class is a model of the XML node in the settings and also has the Create() method to set the properties.</li>
<li><b>CdnSettingsExample</b> - example of how you would use everything mentioned above.</li></ol> 