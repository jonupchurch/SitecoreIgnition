using System;
using Glass.Mapper.Sc;
using Ignition.Core.Mvc;

namespace Ignition.Sc.Components.CustomEditor
{
    public class MockConfigurationData : AbstractConfigurationData
    {
        public MockConfigurationData(ISitecoreContext context, Guid id) : base(context, id, "website", "en-US")
        {
        }
    }
}