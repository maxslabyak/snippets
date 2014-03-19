using System.Collections.Generic;
using System.Linq;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Publishing.Pipelines.GetItemReferences;
using Sitecore.Publishing.Pipelines.PublishItem;

namespace Sitecore.Custom.Publishing
{
    /// <summary>
    /// Gets and publishes the cross-sells for a product
    /// Architecture for Cross Sells is as follows:
    /// Product
    /// |- Shades/Sizes (Folder)
    ///    |- Shade 1
    ///    |- Shade 2
    ///    ...
    /// |- Cross-Sells (CrossSellFolder - Template ID below)
    ///    |- ProductPointer1
    ///    |- ProductPointer2
    /// 
    /// ProductPointer has a DropTree field that allows 
    /// the selection of a single product, so when you view 
    /// raw values, it's a GUID of the selected product
    /// </summary>
    public class PublishCrossSells : GetItemReferencesProcessor
    {
        //GUIDs specific to my Sitecore project
        private const string ProductTemplateId = "{66A91AAC-61E5-4949-991D-3772ED3D63C3}";
        private const string CrossSalesFolder = "{568B223F-6387-4CB1-BC13-152785308A9C}";

        public override void Process(PublishItemContext context)
        {
            Assert.ArgumentNotNull(context, "context");
            List<Item> itemReferences = GetItemReferences(context); // this line calls the method from your custom class
            RegisterReferences(itemReferences, context); // this line registers the references to the related items.
        }

        protected override List<Item> GetItemReferences(PublishItemContext context)
        {
            var referenceList = new List<Item>();
            
            //this is the item being published
            var sourceItem = context.PublishHelper.GetSourceItem(context.ItemId);

            //this should never be true, but why not
            if (sourceItem == null || sourceItem.Empty)
                return referenceList;

            //better way of doing this is via Decorator Pattern, otherwise you 
            //will constantly be recompiling this file with new logic for each
            //template
            switch (sourceItem.TemplateID.ToString())
            {
                case(ProductTemplateId):
                    Log.Info("product publishing detected",this);
                    var crossSellItems = GetCrossSellsForProduct(sourceItem);
                    if (crossSellItems != null && crossSellItems.Any())
                        referenceList.AddRange(crossSellItems);
                    break;
            }

            Log.Info(string.Format("GETITEMREFERENCES: referenceList has {0} items",referenceList.Count()),this);
            
            //only necessary if we want to see the GUIDs in our log file
            foreach (var item in referenceList.Where(item => item!=null && !item.Empty))
            {
                Log.Info(string.Format("GETITEMREFERENCES: Item ID - {0}",item.ID),this);
            }

            return referenceList;
        }

        /// <summary>
        /// This is specific to the architecture and logic of my related items.
        /// Obviously, your architecture and requirements for what constitutes as a 
        /// related item would vary
        /// </summary>
        /// <param name="sourceItem"></param>
        /// <returns></returns>
        private List<Item> GetCrossSellsForProduct(Item sourceItem)
        {
            var crossSellList = new List<Item>();
            
            if (!sourceItem.Children.Any())
                return crossSellList;

            var crossSellFolder = sourceItem.Children.FirstOrDefault(x => x.TemplateID.ToString() == CrossSalesFolder);
            if (crossSellFolder == null)
                return crossSellList;

            foreach (Item crossSellitem in crossSellFolder.Children)
            {
                var itemId = crossSellitem.Fields["Refers-To"].GetValue(false);
                var item = Context.Database.GetItem(itemId);
                
                if(item!=null && !item.Empty)
                    crossSellList.Add(Context.Database.GetItem(itemId));
            }

            return crossSellList;
        }

        
    }
}
