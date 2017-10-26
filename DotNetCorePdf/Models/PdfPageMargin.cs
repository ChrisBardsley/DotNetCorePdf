using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Models
{
    public class PdfPageMargin
    {
        /// <summary>
        /// Size of the top margin, e.g. "2cm"
        /// </summary>
        [WkHtmlToPdfResolveTo("top")]
        public string Top { get; set; }

        /// <summary>
        /// Size of the bottom margin, e.g. "2cm"
        /// </summary>
        [WkHtmlToPdfResolveTo("bottom")]
        public string Bottom { get; set; }

        /// <summary>
        /// Size of the left margin, e.g. "2cm"
        /// </summary>
        [WkHtmlToPdfResolveTo("left")]
        public string Left { get; set; }

        /// <summary>
        /// Size of the right margin, e.g. "2cm"
        /// </summary>
        [WkHtmlToPdfResolveTo("right")]
        public string Right { get; set; }
    }
}
