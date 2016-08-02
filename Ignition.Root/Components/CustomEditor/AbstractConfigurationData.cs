using System;
using Glass.Mapper;
using Glass.Mapper.Sc;
using Ignition.Core.Factories;
using Ignition.Core.Models.BaseModels;
using Ignition.Core.Mvc;
using Ignition.Core.Repositories;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Sites;

namespace Ignition.Root.Components.CustomEditor
{
    public abstract class AbstractConfigurationData : BaseViewModel, IConfigurationData
    {
        protected ISitecoreContext Context { get; set; }

        protected AbstractConfigurationData(ISitecoreContext context, Guid itemId, string language, string contextSite)
        {
            Context = context;
            ItemId = itemId;
            Language = language;
            ContextSite = contextSite;
            SitecoreItem =new SitecoreServiceFactory().GetSitecoreService<MasterDatabaseType>()
                .GetItem<IModelBase>(itemId, Sitecore.Globalization.Language.Parse(language), false, true);
        }

        public string ContextSite { get; set; }
        public string Language { get; set; }

        public virtual string PublicUrl
        {
            get {
                using (new SiteContextSwitcher(SiteContext.GetSite(ContextSite)))
                {
                    return LinkManager.GetItemUrl(SitecoreItem.CastTo<Item>() ,UrlOptions.DefaultOptions);
                }
            }
        }

        public Guid ItemId { get; set; }
        private IModelBase SitecoreItem { get; }
    }
}