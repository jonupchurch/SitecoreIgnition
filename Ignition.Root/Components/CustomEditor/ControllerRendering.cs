using System;
using Ignition.Core.Models.BaseModels;

namespace Ignition.Root.Components.CustomEditor
{
    public class ControllerRendering 
    {
        public bool SharedRendering { get; set; }
        public bool FinalRendering { get; set; }
        public ModelBase SharedRenderingDatasource { get; set; }
        public ModelBase FinalRenderingDatasource { get; set; }
        public ParamsBase RenderingParameters { get; set; }
        public Guid RenderingId { get; set; }
        public bool Cacheable { get; set; }
        public bool ClearOnUpdate { get; set; }
        public bool VaryByData { get; set; }
        public bool VaryByDevice { get; set; }
        public bool VaryByLogin { get; set; }
        public bool VaryByParameters { get; set; }
        public bool VaryByQueryString { get; set; }
        public bool VaryByUser { get; set; }
    }
}
