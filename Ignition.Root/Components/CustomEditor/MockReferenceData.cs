using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ignition.Core.Models.BaseModels;
using Sitecore.Data.Items;

namespace Ignition.Root.Components.CustomEditor
{
    public class MockReferenceData : IReferences
    {
        public Item Item { get; set; }

        public MockReferenceData(Item item)
        {
            Item = item;
        }

        public IEnumerable<IModelBase> InboundReferences { get; set; }
        public IEnumerable<ControllerRendering> PresentationItemsAndDatasources { get; set; }
    }
}