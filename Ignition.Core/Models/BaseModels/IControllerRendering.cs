using System;

namespace Ignition.Core.Models.BaseModels
{
    public interface IControllerRendering : IModelBase
    {
        bool SharedRendering { get; set; }
        bool FinalRendering { get; set; }
        IModelBase SharedRenderingDatasource { get; set; }
        IModelBase FinalRenderingDatasource { get; set; }
        IParamsBase RenderingParameters { get; set; }
        Guid RenderingId { get; set; }
    }
}
