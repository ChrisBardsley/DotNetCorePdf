using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Models
{
    public class PdfHeaderFooter
    {
        /// <summary>
        /// The font size to use for the header/footer/footer, e.g. 13
        /// </summary>
        [WkHtmlToPdfResolveTo("fontSize")]
        public int FontSize { get; set; }

        /// <summary>
        /// The name of the font to use for the header/footer. e.g. "times"
        /// </summary>
        [WkHtmlToPdfResolveTo("fontName")]
        public string FontName { get; set; }

        /// <summary>
        /// The string to print in the left part of the header/footer, note that some sequences are replaced in this string
        /// </summary>
        [WkHtmlToPdfResolveTo("left")]
        public string Left { get; set; }

        /// <summary>
        /// The text to print in the center part of the header/footer.
        /// </summary>
        [WkHtmlToPdfResolveTo("center")]
        public string Center { get; set; }

        /// <summary>
        /// The text to print in the right part of the header/footer.
        /// </summary>
        [WkHtmlToPdfResolveTo("right")]
        public string Right { get; set; }

        /// <summary>
        /// Whether a line should be printed under the header/footer
        /// </summary>
        [WkHtmlToPdfResolveTo("line")]
        public bool Line { get; set; }

        /// <summary>
        /// The amount of space to put between the header/footer and the content, e.g. "1.8". Be aware that if this is too large the header/footer will be printed outside the pdf document. This can be corrected with the margin.top setting.
        /// </summary>
        [WkHtmlToPdfResolveTo("spacing")]
        public string Spacing { get; set; }

        /// <summary>
        /// Url for a HTML document to use for the header/footer.
        /// </summary>
        [WkHtmlToPdfResolveTo("htmlUrl")]
        public string HtmlUrl { get; set; }
    }
}
