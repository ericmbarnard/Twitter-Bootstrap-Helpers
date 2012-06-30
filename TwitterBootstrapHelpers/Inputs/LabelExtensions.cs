﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;

namespace TwitterBootstrapHelpers
{
    public static class LabelExtensions
    {
        #region Label
        
        public static MvcHtmlString Label(this TbHelper html, string expression)
        {
            return Label(html,
                         expression,
                         labelText: null);
        }

        public static MvcHtmlString Label(this TbHelper html, string expression, string labelText)
        {
            return Label(html, expression, labelText, htmlAttributes: null, metadataProvider: null);
        }

        public static MvcHtmlString Label(this TbHelper html, string expression, object htmlAttributes)
        {
            return Label(html, expression, labelText: null, htmlAttributes: htmlAttributes, metadataProvider: null);
        }

        public static MvcHtmlString Label(this TbHelper html, string expression, IDictionary<string, object> htmlAttributes)
        {
            return Label(html, expression, labelText: null, htmlAttributes: htmlAttributes, metadataProvider: null);
        }

        public static MvcHtmlString Label(this TbHelper html, string expression, string labelText, object htmlAttributes)
        {
            return Label(html, expression, labelText, htmlAttributes, metadataProvider: null);
        }

        public static MvcHtmlString Label(this TbHelper html, string expression, string labelText, IDictionary<string, object> htmlAttributes)
        {
            return Label(html, expression, labelText, htmlAttributes, metadataProvider: null);
        }

        internal static MvcHtmlString Label(this TbHelper html, string expression, string labelText, object htmlAttributes, ModelMetadataProvider metadataProvider)
        {
            return Label(html,
                         expression,
                         labelText,
                         HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes),
                         metadataProvider);
        }

        internal static MvcHtmlString Label(this TbHelper html, string expression, string labelText, IDictionary<string, object> htmlAttributes, ModelMetadataProvider metadataProvider)
        {
            return LabelHelper(html,
                               ModelMetadata.FromStringExpression(expression, html.ViewData),
                               expression,
                               labelText,
                               htmlAttributes);
        }

        #endregion

        #region Label For

        public static MvcHtmlString LabelFor<TModel, TValue>(this TBHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return LabelFor<TModel, TValue>(html, expression, labelText: null);
        }

        public static MvcHtmlString LabelFor<TModel, TValue>(this TBHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string labelText)
        {
            return LabelFor(html, expression, labelText, htmlAttributes: null, metadataProvider: null);
        }

        public static MvcHtmlString LabelFor<TModel, TValue>(this TBHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object htmlAttributes)
        {
            return LabelFor(html, expression, labelText: null, htmlAttributes: htmlAttributes, metadataProvider: null);
        }

        public static MvcHtmlString LabelFor<TModel, TValue>(this TBHelper<TModel> html, Expression<Func<TModel, TValue>> expression, IDictionary<string, object> htmlAttributes)
        {
            return LabelFor(html, expression, labelText: null, htmlAttributes: htmlAttributes, metadataProvider: null);
        }

        public static MvcHtmlString LabelFor<TModel, TValue>(this TBHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string labelText, object htmlAttributes)
        {
            return LabelFor(html, expression, labelText, htmlAttributes, metadataProvider: null);
        }

        public static MvcHtmlString LabelFor<TModel, TValue>(this TBHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string labelText, IDictionary<string, object> htmlAttributes)
        {
            return LabelFor(html, expression, labelText, htmlAttributes, metadataProvider: null);
        }

        internal static MvcHtmlString LabelFor<TModel, TValue>(this TBHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string labelText, object htmlAttributes, ModelMetadataProvider metadataProvider)
        {
            return LabelFor(html,
                            expression,
                            labelText,
                            HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes),
                            metadataProvider);
        }

        internal static MvcHtmlString LabelFor<TModel, TValue>(this TBHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string labelText, IDictionary<string, object> htmlAttributes, ModelMetadataProvider metadataProvider)
        {
            return LabelHelper(html,
                               ModelMetadata.FromLambdaExpression(expression, html.ViewData), // just pass null since all the calling methods do here
                               ExpressionHelper.GetExpressionText(expression),
                               labelText,
                               htmlAttributes);
        }

        #endregion

        #region LabelForModel
        
        public static MvcHtmlString LabelForModel(this TbHelper html)
        {
            return LabelForModel(html, labelText: null);
        }

        public static MvcHtmlString LabelForModel(this TbHelper html, string labelText)
        {
            return LabelHelper(html, html.ViewData.ModelMetadata, String.Empty, labelText);
        }

        public static MvcHtmlString LabelForModel(this TbHelper html, object htmlAttributes)
        {
            return LabelHelper(html, html.ViewData.ModelMetadata, String.Empty, labelText: null, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString LabelForModel(this TbHelper html, IDictionary<string, object> htmlAttributes)
        {
            return LabelHelper(html, html.ViewData.ModelMetadata, String.Empty, labelText: null, htmlAttributes: htmlAttributes);
        }

        public static MvcHtmlString LabelForModel(this TbHelper html, string labelText, object htmlAttributes)
        {
            return LabelHelper(html, html.ViewData.ModelMetadata, String.Empty, labelText, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString LabelForModel(this TbHelper html, string labelText, IDictionary<string, object> htmlAttributes)
        {
            return LabelHelper(html, html.ViewData.ModelMetadata, String.Empty, labelText, htmlAttributes);
        }

        #endregion

        internal static MvcHtmlString LabelHelper(TbHelper html, ModelMetadata metadata, string htmlFieldName, string labelText = null, IDictionary<string, object> htmlAttributes = null)
        {
            string resolvedLabelText = labelText ?? metadata.DisplayName ?? metadata.PropertyName ?? htmlFieldName.Split('.').Last();
            if (String.IsNullOrEmpty(resolvedLabelText))
            {
                return MvcHtmlString.Empty;
            }

            TagBuilder tag = new TagBuilder("label");
            tag.Attributes.Add("for", TagBuilder.CreateSanitizedId(html.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(htmlFieldName)));
            tag.SetInnerText(resolvedLabelText);
            tag.MergeAttributes(htmlAttributes, replaceExisting: true);
            
            // the magic
            tag.AddCssClass(TbCss.CONTROL_LABEL);

            return new MvcHtmlString(tag.ToString(TagRenderMode.Normal));
        }
    }
}
