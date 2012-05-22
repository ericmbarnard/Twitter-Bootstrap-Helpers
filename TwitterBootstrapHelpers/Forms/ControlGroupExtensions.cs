using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using TwitterBootstrapHelpers.Forms;

namespace TwitterBootstrapHelpers
{
    public enum ControlGroupValidation
    {
        None = 0,
        Warning = 2,
        Error = 4,
        Success = 6
    }

    public static class ControlGroupExtensions
    {
        #region API

        public static ControlGroup BeginControlGroup(this TBHelper helper)
        {
            return BeginControlGroupHelper(helper, htmlAttributes: null);
        }

        public static ControlGroup BeginControlGroup(this TBHelper helper, IDictionary<string, object> htmlAttributes)
        {
            return BeginControlGroupHelper(helper, htmlAttributes: htmlAttributes);
        }

        public static ControlGroup BeginControlGroup(this TBHelper helper, object htmlAttributes)
        {
            return BeginControlGroupHelper(helper, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        } 

        #endregion

        private static ControlGroup BeginControlGroupHelper(TBHelper helper, IDictionary<string, object> htmlAttributes)
        {
            ControlGroup group = new ControlGroup(helper.ViewContext);

            group.WriteTag(htmlAttributes, TagRenderMode.StartTag);

            return group;
        }
    }
}
