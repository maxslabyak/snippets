using System.Xml;
using Sitecore;
using Sitecore.Configuration;
using Sitecore.Reflection;

namespace Image0.Core
{
    public static class ReflectionHelper
    {
        public static void SetPropertiesFromConfig(object obj, string nodePath, string[] exclude)
        {
            if (obj == null) return;
            var configNode = Factory.GetConfigNode(nodePath);
            if (configNode == null) return;

            foreach (XmlNode childNode in configNode.ChildNodes)
            {
                if (!StringUtil.Contains(childNode.Name, exclude))
                {
                    ReflectionUtil.SetProperty(obj, childNode.Name, childNode.InnerText);
                }
            }
        }
    }
}
