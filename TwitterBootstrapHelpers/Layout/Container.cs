using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using TwitterBootstrapHelpers.Core;

namespace TwitterBootstrapHelpers.Layout
{
    public class Container : ContainerElementBase
    {
        public Container(ViewContext viewContext)
            : this(viewContext, false)
        {
        }

        public Container(ViewContext viewContext, bool fluid)
            : base("div", viewContext)
        {
            Fluid = fluid;
        }

        public bool Fluid { get; set; }

        public override void OnWriteTag(TagBuilder tagBuilder, TagRenderMode renderMode, ViewContext viewContext)
        {
            base.OnWriteTag(tagBuilder, renderMode, viewContext);

            tagBuilder.AddCssClass(Fluid ? TBCss.CONTAINER_FLUID : TBCss.CONTAINER);
        }
    }
}
