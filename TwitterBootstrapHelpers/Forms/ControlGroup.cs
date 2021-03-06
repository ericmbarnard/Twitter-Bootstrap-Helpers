﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

using TwitterBootstrapHelpers.Core;

namespace TwitterBootstrapHelpers.Forms
{
    public class ControlGroup : ContainerElementBase
    {
        public ControlGroup(ViewContext viewContext)
            : this(viewContext, ControlGroupValidation.None)
        {        
        }

        public ControlGroup(ViewContext viewContext, ControlGroupValidation validation)
            : base("div", viewContext)
        {
            Validation = validation;
        }

        public ControlGroupValidation Validation { get; set; }

        public override void OnWriteTag(TagBuilder tagBuilder, TagRenderMode renderMode, ViewContext viewContext)
        {
            base.OnWriteTag(tagBuilder, renderMode, viewContext);

            tagBuilder.AddCssClass(TbCss.CONTROL_GROUP);

            switch (Validation)
            {
                case ControlGroupValidation.Warning:
                    tagBuilder.AddCssClass(TbCss.WARNING);
                    break;
                case ControlGroupValidation.Error:
                    tagBuilder.AddCssClass(TbCss.ERROR);
                    break;
                case ControlGroupValidation.Success:
                    tagBuilder.AddCssClass(TbCss.SUCCESS);
                    break;
                case ControlGroupValidation.None:
                default:
                    // don't add any css    
                    break;
            }
        }
    }
}
