using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace TwitterBootstrapHelpers
{
    public enum FormStyle
    {
        Vertical = 0,
        Inline = 2,
        Search = 4,
        Horizontal = 6
    }

    public static class FormExtensions
    {
        #region Form
        
        public static MvcForm BeginForm(this TbHelper htmlHelper)
        {
            return System.Web.Mvc.Html.FormExtensions.BeginForm(htmlHelper.ToHtmlHelper(), null, null, FormMethod.Post, new { @class = "form-vertical" });
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, object routeValues)
        {
            return BeginForm(htmlHelper, null, null, new RouteValueDictionary(routeValues), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, RouteValueDictionary routeValues)
        {
            return BeginForm(htmlHelper, null, null, routeValues, FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName)
        {
            return BeginForm(htmlHelper, actionName, controllerName, new RouteValueDictionary(), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, object routeValues)
        {
            return BeginForm(htmlHelper, actionName, controllerName, new RouteValueDictionary(routeValues), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            return BeginForm(htmlHelper, actionName, controllerName, routeValues, FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, FormMethod method)
        {
            return BeginForm(htmlHelper, actionName, controllerName, new RouteValueDictionary(), method, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, object routeValues, FormMethod method)
        {
            return BeginForm(htmlHelper, actionName, controllerName, new RouteValueDictionary(routeValues), method, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method)
        {
            return BeginForm(htmlHelper, actionName, controllerName, routeValues, method, new RouteValueDictionary());
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, FormMethod method, object htmlAttributes)
        {
            return BeginForm(htmlHelper, actionName, controllerName, new RouteValueDictionary(), method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return BeginForm(htmlHelper, actionName, controllerName, new RouteValueDictionary(), method, htmlAttributes);
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, object routeValues, FormMethod method, object htmlAttributes)
        {
            return BeginForm(htmlHelper, actionName, controllerName, new RouteValueDictionary(routeValues), method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm(this TbHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return FormHelper(htmlHelper, actionName, controllerName, routeValues, method, htmlAttributes);
        }

        #endregion

        #region Route Forms
        
        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, object routeValues)
        {
            return BeginRouteForm(htmlHelper, null /* routeName */, new RouteValueDictionary(routeValues), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, RouteValueDictionary routeValues)
        {
            return BeginRouteForm(htmlHelper, null /* routeName */, routeValues, FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName)
        {
            return BeginRouteForm(htmlHelper, routeName, new RouteValueDictionary(), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, object routeValues)
        {
            return BeginRouteForm(htmlHelper, routeName, new RouteValueDictionary(routeValues), FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, RouteValueDictionary routeValues)
        {
            return BeginRouteForm(htmlHelper, routeName, routeValues, FormMethod.Post, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, FormMethod method)
        {
            return BeginRouteForm(htmlHelper, routeName, new RouteValueDictionary(), method, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, object routeValues, FormMethod method)
        {
            return BeginRouteForm(htmlHelper, routeName, new RouteValueDictionary(routeValues), method, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, RouteValueDictionary routeValues, FormMethod method)
        {
            return BeginRouteForm(htmlHelper, routeName, routeValues, method, new RouteValueDictionary());
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, FormMethod method, object htmlAttributes)
        {
            return RouteFormHelper(htmlHelper, routeName, new RouteValueDictionary(), method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return RouteFormHelper(htmlHelper, routeName, new RouteValueDictionary(), method, htmlAttributes);
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, object routeValues, FormMethod method, object htmlAttributes)
        {
            return RouteFormHelper(htmlHelper, routeName, new RouteValueDictionary(routeValues), method, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginRouteForm(this TbHelper htmlHelper, string routeName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            return RouteFormHelper(htmlHelper, routeName, routeValues, method, htmlAttributes);
        }

        #endregion

        internal static MvcForm RouteFormHelper(this TbHelper htmlHelper, FormStyle formStyle, string routeName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            htmlAttributes = BuildFormCss(htmlAttributes, formStyle);
            return System.Web.Mvc.Html.FormExtensions.BeginRouteForm(htmlHelper.ToHtmlHelper(), routeName, routeValues, method, htmlAttributes);
        }

        internal static MvcForm RouteFormHelper(this TbHelper htmlHelper, string routeName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            htmlAttributes = BuildFormCss(htmlAttributes, FormStyle.Vertical);
            return System.Web.Mvc.Html.FormExtensions.BeginRouteForm(htmlHelper.ToHtmlHelper(), routeName, routeValues, method, htmlAttributes);
        }

        internal static MvcForm FormHelper(this TbHelper htmlHelper, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            htmlAttributes = BuildFormCss(htmlAttributes, FormStyle.Vertical);
            return System.Web.Mvc.Html.FormExtensions.BeginForm(htmlHelper.ToHtmlHelper(), actionName, controllerName, routeValues, method, htmlAttributes);
        }

        internal static MvcForm FormHelper(this TbHelper htmlHelper, FormStyle formStyle, string actionName, string controllerName, RouteValueDictionary routeValues, FormMethod method, IDictionary<string, object> htmlAttributes)
        {
            htmlAttributes = BuildFormCss(htmlAttributes, formStyle);
            return System.Web.Mvc.Html.FormExtensions.BeginForm(htmlHelper.ToHtmlHelper(), actionName, controllerName, routeValues, method, htmlAttributes);
        }

        internal static IDictionary<string, object> BuildFormCss(IDictionary<string, object> htmlAttributes, FormStyle formStyle)
        {
            object classes;
            string css = "";

            if (htmlAttributes.TryGetValue("class", out classes))
            {
                css = (string)classes;

                //tack on a space since it was already in here
                css += " ";
            }

            switch (formStyle)
            {
                case FormStyle.Vertical:
                    if (!css.Contains("form-vertical"))
                    {
                        css += "form-vertical";
                    }
                    break;
                case FormStyle.Inline:
                    if (!css.Contains("form-inline"))
                    {
                        css += "form-inline";
                    }
                    break;
                case FormStyle.Search:
                    if (!css.Contains("form-search"))
                    {
                        css += "form-search";
                    }
                    break;
                case FormStyle.Horizontal:
                    if (!css.Contains("form-horizontal"))
                    {
                        css += "form-horizontal";
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException("formStyle");
            }

            htmlAttributes["class"] = css;

            return htmlAttributes;
        }
    }
}
