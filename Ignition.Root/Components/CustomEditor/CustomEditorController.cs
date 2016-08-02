using System;
using System.Web.Mvc;
using Ignition.Core.Mvc;

namespace Ignition.Root.Components.CustomEditor
{
    public class CustomEditorController : IgnitionController
    {
        [HttpGet]
        public JsonResult ConfigurationTab(Guid itemId)
        {
            return Json(new MockConfigurationData(SitecoreContext, itemId));
        }
        [HttpGet]
        public JsonResult References(Guid itemId)
        {
            return Json(new MockReferenceData(Sitecore.Context.Item));
        }
    }
}