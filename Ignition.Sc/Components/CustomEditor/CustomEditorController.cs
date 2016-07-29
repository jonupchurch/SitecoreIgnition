using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ignition.Core.Mvc;

namespace Ignition.Sc.Components.CustomEditor
{
    public class CustomEditorController : IgnitionController
    {
        [HttpGet]
        public JsonResult ConfigurationTab(Guid itemId)
        {
            return Json(new MockConfigurationData(SitecoreContext, itemId));
        }
    }
}