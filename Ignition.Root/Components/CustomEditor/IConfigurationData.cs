using System;

namespace Ignition.Root.Components.CustomEditor
{
    public interface IConfigurationData
    {
        string ContextSite { get; set; }
        string Language { get; set; }
        string PublicUrl { get; }
        Guid ItemId { get; set; }
    }
}
