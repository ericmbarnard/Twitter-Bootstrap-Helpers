using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TwitterBootstrapHelpers.Layout;
using System.Web.Mvc;

namespace TwitterBootstrapHelpers
{
    public static class RowExtensions
    {
        #region Row API

        public static Row BeginRow(this TbHelper helper)
        {
            return BeginRowHelper(helper, fluid: false, htmlAttributes: null);
        }

        public static Row BeginRow(this TbHelper helper, object htmlAttributes)
        {
            return BeginRowHelper(helper, fluid: false, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static Row BeginRow(this TbHelper helper, IDictionary<string, object> htmlAttributes)
        {
            return BeginRowHelper(helper, fluid: false, htmlAttributes: htmlAttributes);
        }

        #endregion

        #region Fluid Row API

        public static Row BeginFluidRow(this TbHelper helper)
        {
            return BeginRowHelper(helper, fluid: true, htmlAttributes: null);
        }

        public static Row BeginFluidRow(this TbHelper helper, object htmlAttributes)
        {
            return BeginRowHelper(helper, fluid: true, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static Row BeginFluidRow(this TbHelper helper, IDictionary<string, object> htmlAttributes)
        {
            return BeginRowHelper(helper, fluid: true, htmlAttributes: htmlAttributes);
        }

        #endregion

        private static Row BeginRowHelper(this TbHelper helper, bool fluid, IDictionary<string, object> htmlAttributes)
        {
            Row row = new Row(helper.ViewContext, fluid);

            row.WriteTag(htmlAttributes, TagRenderMode.StartTag);

            return row;
        }
    }
}
