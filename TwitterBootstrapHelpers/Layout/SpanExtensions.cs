using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using TwitterBootstrapHelpers.Layout;

namespace TwitterBootstrapHelpers
{
    public static class SpanExtensions
    {
        public static Span BeginSpan(this TBHelper helper, int spanWidth)
        {
            return SpanHelper(helper, spanWidth, offset: null, htmlAttributes: null);
        }

        public static Span BeginSpan(this TBHelper helper, int spanWidth, int offset)
        {
            return SpanHelper(helper, spanWidth, offset: offset, htmlAttributes: null);
        }

        public static Span BeginSpan(this TBHelper helper, int spanWidth, IDictionary<string, object> htmlAttributes)
        {
            return SpanHelper(helper, spanWidth, offset: null, htmlAttributes: htmlAttributes);
        }

        public static Span BeginSpan(this TBHelper helper, int spanWidth, object htmlAttributes)
        {
            return SpanHelper(helper, spanWidth, offset: null, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static Span BeginSpan(this TBHelper helper, int spanWidth, int offset, IDictionary<string, object> htmlAttributes)
        {
            return SpanHelper(helper, spanWidth, offset: offset, htmlAttributes: htmlAttributes);
        }

        public static Span BeginSpan(this TBHelper helper, int spanWidth, int offset, object htmlAttributes)
        {
            return SpanHelper(helper, spanWidth, offset: offset, htmlAttributes: HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        private static Span SpanHelper(TBHelper helper, int spanWidth, int? offset, IDictionary<string, object> htmlAttributes)
        {
            Span span = new Span(helper.ViewContext, spanWidth, offset);
 
            span.WriteTag(htmlAttributes, TagRenderMode.StartTag);

            return span;
        }
    }
}
