using System.Collections.Generic;
using Ignition.Core.Models.BaseModels;

namespace Ignition.Root.Components.CustomEditor
{
    public interface IReferences
    {
        IEnumerable<IModelBase> InboundReferences { get; }
        IEnumerable<ControllerRendering> PresentationItemsAndDatasources { get; set; }
    }
}
