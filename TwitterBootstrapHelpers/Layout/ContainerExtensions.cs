using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

using TwitterBootstrapHelpers.Layout;

namespace TwitterBootstrapHelpers
{
    public static class ContainerExtensions
    {
        #region Container API

        public static Container BeginContainer(this TBHelper helper)
        {
            return BeginContainerHelper(helper, htmlAttributes: null, fluid: false);
        }

        public static Container BeginContainer(this TBHelper helper, IDictionary<string, object> htmlAttributes)
        {
            return BeginContainerHelper(helper, htmlAttributes: htmlAttributes, fluid: false);
        }

        public static Container BeginContainer(this TBHelper helper, object htmlAttributes)
        {
            return BeginContainerHelper(helper, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), fluid: false);
        } 

        #endregion

        #region Fluid Container API

        public static Container BeginFluidContainer(this TBHelper helper)
        {
            return BeginContainerHelper(helper, htmlAttributes: null, fluid: true);
        }

        public static Container BeginFluidContainer(this TBHelper helper, IDictionary<string, object> htmlAttributes)
        {
            return BeginContainerHelper(helper, htmlAttributes: htmlAttributes, fluid: true);
        }

        public static Container BeginFluidContainer(this TBHelper helper, object htmlAttributes)
        {
            return BeginContainerHelper(helper, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes), fluid: true);
        }
        #endregion

        private static Container BeginContainerHelper(this TBHelper helper, IDictionary<string, object> htmlAttributes, bool fluid)
        {
            Container container = new Container(helper.ViewContext, fluid);

            container.WriteTag(htmlAttributes, TagRenderMode.StartTag);

            return container;
        }
    }
}
