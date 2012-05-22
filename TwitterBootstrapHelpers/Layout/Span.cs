using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitterBootstrapHelpers.Core;
using System.Web.Mvc;

namespace TwitterBootstrapHelpers.Layout
{
    public class Span : ContainerElementBase
    {
        public Span(ViewContext viewContext, int spanWidth)
            : this(viewContext, spanWidth, null)
        {
        }

        public Span(ViewContext viewContext, int spanWidth, int? offset)
            : base("div", viewContext)
        {
            Offset = offset;
        }

        public int SpanWidth { get; set; }
        public int? Offset { get; set; }

        public override void OnWriteTag(TagBuilder tagBuilder, TagRenderMode renderMode, ViewContext viewContext)
        {
            base.OnWriteTag(tagBuilder, renderMode, viewContext);

            if (SpanWidth < 17 && SpanWidth > 0)
            {
                tagBuilder.AddCssClass(TBCss.Span(SpanWidth));
            }

            if (Offset.HasValue && Offset > 0 && Offset < 17)
            {
                tagBuilder.AddCssClass(TBCss.Offset(Offset.Value));
            }
        }
    }
}
