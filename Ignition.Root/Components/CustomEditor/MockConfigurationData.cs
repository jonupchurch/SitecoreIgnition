using System;
using Glass.Mapper.Sc;

namespace Ignition.Root.Components.CustomEditor
{
    public class MockConfigurationData : AbstractConfigurationData
    {
        public MockConfigurationData(ISitecoreContext context, Guid id) : base(context, id, "website", "en-US")
        {
        }
    }
}