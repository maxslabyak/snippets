Sitecore.Configuration.Factory is a very powerful class.

Sitecore configuration files are a great place to store environment-specific settings. Sitecore itself is a horrible place to store environment-specific files, because content gets published from environment to environment and is extremely easy to overwrite settings by mistake.

Configuration files on the other hand are easily managed. All you have to do is dump a .config file in your /App_Config/Include directory and Sitecore will pick it up. 

You can confirm this via http://{yoursite}/sitecore/admin/showconfig.aspx
