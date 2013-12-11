using System;
using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Sitecore.Data;
using System.Runtime.Serialization;

namespace Image0.ORM.Models.Navigation
{
    [SitecoreClass(TemplateId = IDs.TemplateIDs.NavItem)]
    [DataContract]
    public class NavItem
    {
        // IDs is a folder
        // TemplateIDs is a static class containing constants (public const string) 
        // of Template IDs
        public static readonly ID TemplateId = ID.Parse(IDs.TemplateIDs.NavItem);

        [SitecoreId]
        [DataMember]
        public virtual Guid Id { get; set; }

        [SitecoreField]
        public virtual string Title { get; set; }

        [SitecoreField]
        public virtual Glass.Sitecore.Mapper.FieldTypes.Link Link { get; set; }

        [DataMember]
        public string TargetUrl
        {
            get
            {
                return Link != null ? Link.Url : "#";
            }
        }

        [SitecoreField]
        public virtual bool HideFromSitemap { get; set; }

        [SitecoreField]
        public virtual bool HideSubmenu { get; set; }
        
        [SitecoreField]
        public virtual bool HideFromNav { get; set; }
        
        [SitecoreField]
        public virtual bool HideFromBreadcrumb { get; set; }
        
        [SitecoreField]
        public virtual bool IndentChildren { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<NavCollection> Collection { get; set; }

       

    }
}