using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace TwitterBootstrapHelpers.Core
{
    public abstract class ContainerElementBase : IDisposable
    {
        private bool _disposed;
        private ViewContext _viewContext;
        private string _elementName;

        public ContainerElementBase(string elementName, ViewContext viewContext)
        {
            if (String.IsNullOrEmpty(elementName))
                throw new ArgumentNullException("element");

            if (viewContext == null)
                throw new ArgumentNullException("viewContext");

            _elementName = elementName;
            _viewContext = viewContext;
        }

        public void WriteTag(IDictionary<string, object> htmlAttributes, TagRenderMode renderMode)
        {
            TagBuilder tagBuilder = new TagBuilder(_elementName);
            tagBuilder.MergeAttributes(htmlAttributes, true);

            // call on any over-ridden behavior
            this.OnWriteTag(tagBuilder, renderMode, _viewContext);

            // write it out
            _viewContext.Writer.Write(tagBuilder.ToString(renderMode));
        }

        public virtual void OnWriteTag(TagBuilder tagBuilder, TagRenderMode renderMode, ViewContext viewContext)
        {
            // here to be over-ridden
        }

        public virtual bool IsDisposed
        {
            get { return _disposed; }
        }

        public virtual void Dispose()
        {
            if (!_disposed)
            {
                _disposed = true;

                _viewContext.Writer.Write("</" + _elementName + ">");
            }
        }
    }
}
