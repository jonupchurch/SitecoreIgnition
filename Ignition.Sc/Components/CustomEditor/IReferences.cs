using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ignition.Core.Models.BaseModels;

namespace Ignition.Sc.Components.CustomEditor
{
    public interface IReferences
    {
        IEnumerable<IModelBase> InboundReferences { get; }
        IEnumerable<IControllerRendering> PresentationItemsAndDatasources { get; set; }
    }
}
