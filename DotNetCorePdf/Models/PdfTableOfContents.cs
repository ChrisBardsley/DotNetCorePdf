using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Models
{
    public class PdfTableOfContents
    {
        /// <summary>
        /// Should we use a dotted line when creating a table of content?
        /// </summary>
        [WkHtmlToPdfResolveTo("useDottedLines")]
        public bool UseDottedLines { get; set; }

        /// <summary>
        /// The caption to use when creating a table of content.
        /// </summary>
        [WkHtmlToPdfResolveTo("captionText")]
        public string CaptionText { get; set; }

        /// <summary>
        /// Should we create links from the table of content into the actual content?
        /// </summary>
        [WkHtmlToPdfResolveTo("forwardLinks")]
        public bool ForwardLinks { get; set; }

        /// <summary>
        /// Should we link back from the content to this table of content.
        /// </summary>
        [WkHtmlToPdfResolveTo("backLinks")]
        public bool BackLinks { get; set; }

        /// <summary>
        /// The indentation used for every table of content level, e.g. "2em".
        /// </summary>
        [WkHtmlToPdfResolveTo("indentation")]
        public string Indentation { get; set; }

        /// <summary>
        /// How much should we scale down the font for every toc level? E.g. "0.8"
        /// </summary>
        [WkHtmlToPdfResolveTo("fontScale")]
        public string FontScale { get; set; }
    }
}
