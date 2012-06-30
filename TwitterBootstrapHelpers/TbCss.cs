using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterBootstrapHelpers
{
    public static class TbCss
    {
        #region Code

        public const string PRETTYPRINT = "prettyprint";
        public const string LINENUMS = "linenums";

        #endregion

        #region Container

        public const string CONTAINER = "container";
        public const string CONTAINER_FLUID = "container-fluid"; 
        
        #endregion
                
        #region Forms

        public const string FORM_VERTICAL = "form-vertical";
        public const string FORM_INLINE = "form-inline";
        public const string FORM_SEARCH = "form-search";
        public const string FORM_HORIZONTAL = "form-horizontal";

        public const string CONTROL_GROUP = "control-group";
        public const string CONTROLS = "controls";

        public const string WARNING = "warning";
        public const string ERROR = "error";
        public const string SUCCESS = "success";

        #endregion

        #region Inputs

        public const string CONTROL_LABEL = "control-label";

        #endregion

        #region Layout Utility

        public const string PULL_RIGHT = "pull-right";
        public const string PULL_LEFT = "pull-left";
        public const string WELL = "well";

        #endregion

        #region Offset

        public const string OFFSET1 = "offset1";
        public const string OFFSET2 = "offset2";
        public const string OFFSET3 = "offset3";
        public const string OFFSET4 = "offset4";
        public const string OFFSET5 = "offset5";
        public const string OFFSET6 = "offset6";
        public const string OFFSET7 = "offset7";
        public const string OFFSET8 = "offset8";
        public const string OFFSET9 = "offset9";
        public const string OFFSET10 = "offset10";
        public const string OFFSET11 = "offset11";

        /// <summary>
        /// Creates an Offset of the desired size
        /// </summary>
        /// <param name="offset">The Offset Size</param>
        /// <returns></returns>
        public static string Offset(int offset)
        {
            return "offset" + offset.ToString();
        }    

        #endregion

        #region Row

        public const string ROW = "row";
        public const string ROW_FLUID = "row-fluid";
        
        #endregion

        #region Span

        public const string SPAN1 = "span2";
        public const string SPAN2 = "span2";
        public const string SPAN3 = "span3";
        public const string SPAN4 = "span4";
        public const string SPAN5 = "span5";
        public const string SPAN6 = "span6";
        public const string SPAN7 = "span7";
        public const string SPAN8 = "span8";
        public const string SPAN9 = "span9";
        public const string SPAN10 = "span10";
        public const string SPAN11 = "span11";
        public const string SPAN12 = "span12";

        /// <summary>
        /// Creates a span of the size that is passed in
        /// </summary>
        /// <param name="span">The Span Size</param>
        /// <returns></returns>
        public static string Span(int span)
        {
            return "span" + span.ToString();
        }

        #endregion

        #region Tables

        public const string TABLE_BASIC = "table";
        public const string TABLE_BORDERED = "table-bordered";
        public const string TABLE_STRIPED = "table-striped";
        public const string TABLE_CONDENSED = "table-condensed";

        #endregion

        #region Typography

        public const string INITIALISM = "initialism";
        public const string UNSTYLED = "unstyled";
        public const string DL_HORIZONTAL = "dl-horizontal";

        #endregion

        #region Visibility

        public const string VISIBLE_PHONE = "visible-phone";
        public const string VISIBLE_TABLET = "visible-tablet";
        public const string VISIBLE_DESKTOP = "visible-desktop";

        public const string HIDDEN_PHONE = "hidden-phone";
        public const string HIDDEN_TABLET = "hidden-tablet";
        public const string HIDDEN_DESKTOP = "hiddent-desktop";

        #endregion        
    }
}
