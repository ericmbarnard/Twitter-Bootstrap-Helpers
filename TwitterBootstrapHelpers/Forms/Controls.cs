using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

using TwitterBootstrapHelpers.Core;

namespace TwitterBootstrapHelpers.Forms
{
    public class Controls : ContainerElementBase
    {
        public Controls(ViewContext viewContext)
            : base("div", viewContext)
        {
        }

        public override void OnWriteTag(TagBuilder tagBuilder, TagRenderMode renderMode, ViewContext viewContext)
        {
            base.OnWriteTag(tagBuilder, renderMode, viewContext);

            tagBuilder.AddCssClass(TbCss.CONTROLS);
        }
    }
}
