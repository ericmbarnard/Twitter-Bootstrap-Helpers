using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TwitterBootstrapHelpers.Core;
using System.Web.Mvc;

namespace TwitterBootstrapHelpers.Layout
{
    public class Row : ContainerElementBase
    {
        public Row(ViewContext viewContext)
            : this(viewContext, false)
        {
        }

        public Row(ViewContext viewContext, bool fluid)
            : base("div", viewContext)
        {
            Fluid = fluid;
        }

        public bool Fluid { get; set; }

        public override void OnWriteTag(TagBuilder tagBuilder, TagRenderMode renderMode, ViewContext viewContext)
        {
            base.OnWriteTag(tagBuilder, renderMode, viewContext);


            tagBuilder.AddCssClass(Fluid ? TBCss.ROW_FLUID : TBCss.ROW);
        }
    }
}
