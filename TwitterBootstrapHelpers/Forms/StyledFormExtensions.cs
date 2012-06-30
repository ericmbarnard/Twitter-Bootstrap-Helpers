using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc.Html;
using System.Web.Routing;
using System.Web.Mvc;

namespace TwitterBootstrapHelpers
{
    public static class StyledFormExtensions
    {
        #region Form

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle)
        {
            IDictionary<string, object> css = new Dictionary<string, object>();
            FormExtensions.BuildFormCss(css, formStyle);
            return System.Web.Mvc.Html.FormExtensions.BeginForm(htmlHelper.ToHtmlHelper(), null, null, FormMethod.Post, css);
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, object routeValues)
        {
            return BeginForm(htmlHelper, formStyle, null, null, new RouteValueDictionary(routeValues), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, RouteValueDictionary routeValues)
        {
            return BeginForm(htmlHelper, formStyle, null, null, routeValues, FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, new RouteValueDictionary(), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, object routeValues)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, new RouteValueDictionary(routeValues), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, routeValues, FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, FormMethod method)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, new RouteValueDictionary(), method, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, object routeValues, FormMethod method)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, new RouteValueDictionary(routeValues), method, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, routeValues, method, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, FormMethod method, object htmlAttributes)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, new RouteValueDictionary(), method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, new RouteValueDictionary(), method, htmlAttributes);
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, object routeValues, FormMethod method, object htmlAttributes)
        {
            return BeginForm(htmlHelper, formStyle, actionName, controllerName, new RouteValueDictionary(routeValues), method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return FormExtensions.FormHelper(htmlHelper, formStyle, actionName, controllerName, routeValues, method, htmlAttributes);
        }

        #endregion

        #region Route Forms

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, object routeValues)
        {
            return BeginRouteForm(htmlHelper, formStyle, null /* routeName */, new RouteValueDictionary(routeValues), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, RouteValueDictionary routeValues)
        {
            return BeginRouteForm(htmlHelper, formStyle, null /* routeName */, routeValues, FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, new RouteValueDictionary(), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, object routeValues)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, new RouteValueDictionary(routeValues), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, RouteValueDictionary routeValues)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, routeValues, FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, FormMethod method)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, new RouteValueDictionary(), method, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, object routeValues, FormMethod method)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, new RouteValueDictionary(routeValues), method, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, RouteValueDictionary routeValues, FormMethod method)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, routeValues, method, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, FormMethod method, object htmlAttributes)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, new RouteValueDictionary(), method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, new RouteValueDictionary(), method, htmlAttributes);
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, object routeValues, FormMethod method, object htmlAttributes)
        {
            return BeginRouteForm(htmlHelper, formStyle, routeName, new RouteValueDictionary(routeValues), method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, FormStyle formStyle, string routeName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return FormExtensions.RouteFormHelper(htmlHelper, formStyle, routeName, routeValues, method, htmlAttributes);
        }

        #endregion

    }
}
