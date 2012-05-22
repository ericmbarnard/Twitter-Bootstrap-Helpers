using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;

namespace TwitterBootstrapHelpers
{
    /// <summary>
    /// The Twitter Bootstrap Html Helper
    /// </summary>
    public class TBHelper
    {
        private HtmlHelper _helper;

        public TBHelper(ViewContext viewContext, IViewDataContainer viewDataContainer, RouteCollection routeCollection)
        {
            if (viewContext == null)
                throw new ArgumentNullException("viewContext");

            if (viewDataContainer == null)
                throw new ArgumentNullException("viewDataContainer");

            if (routeCollection == null)
                throw new ArgumentNullException("routeCollection");

            ViewContext = viewContext;
            ViewDataContainer = viewDataContainer;
            RouteCollection = routeCollection;

            _helper = new HtmlHelper(viewContext, viewDataContainer, routeCollection);
        }

        public TBHelper(ViewContext viewContext, IViewDataContainer viewDataContainer)
            : this(viewContext, viewDataContainer, RouteTable.Routes)
        {        
        }

        public ViewContext ViewContext { get; private set; }
        public IViewDataContainer ViewDataContainer { get; internal set; }
        public RouteCollection RouteCollection { get; internal set; }

        public ViewDataDictionary ViewData
        {
            get { return ViewDataContainer.ViewData; }
        }

        public virtual HtmlHelper ToHtmlHelper()
        {
            return new HtmlHelper(this.ViewContext, this.ViewDataContainer, this.RouteCollection);
        }
    }

    public class TBHelper<TModel> : TBHelper
    {
        ViewDataDictionary<TModel> _viewData;

        public TBHelper(ViewContext viewContext, IViewDataContainer viewDataContainer, RouteCollection routeCollection)
            : base(viewContext, viewDataContainer, routeCollection)
        {
            _viewData = new ViewDataDictionary<TModel>(viewDataContainer.ViewData);
        }

        public TBHelper(ViewContext viewContext, IViewDataContainer viewDataContainer)
            : this(viewContext, viewDataContainer, RouteTable.Routes)
        {
        }

        public new ViewDataDictionary<TModel> ViewData
        {
            get { return _viewData; }
        }
    }
}
