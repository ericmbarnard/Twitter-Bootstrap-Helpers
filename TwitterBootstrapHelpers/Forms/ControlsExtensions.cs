using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

using TwitterBootstrapHelpers.Forms;

namespace TwitterBootstrapHelpers
{
    public static class ControlsExtensions
    {
        #region API

        public static Controls BeginControlGroup(this TBHelper helper)
        {
            return BeginControlsHelper(helper, htmlAttributes: null);
        }

        public static Controls BeginControlGroup(this TBHelper helper, IDictionary<string, object> htmlAttributes)
        {
            return BeginControlsHelper(helper, htmlAttributes: htmlAttributes);
        }

        public static Controls BeginControlGroup(this TBHelper helper, object htmlAttributes)
        {
            return BeginControlsHelper(helper, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        #endregion

        private static Controls BeginControlsHelper(TBHelper helper, IDictionary<string, object> htmlAttributes)
        {
            Controls controls = new Controls(helper.ViewContext);
            controls.WriteTag(htmlAttributes, TagRenderMode.StartTag);

            return controls;
        }
    }
}
