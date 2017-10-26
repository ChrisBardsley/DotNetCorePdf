using DotNetCorePdf.Enums;
using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Models
{
    public class PdfWebSettings
    {
        /// <summary>
        /// Should we print the background?
        /// </summary>
        [WkHtmlToPdfResolveTo("background")]
        public bool Background { get; set; }

        /// <summary>
        /// Should we load images?
        /// </summary>
        [WkHtmlToPdfResolveTo("loadImages")]
        public bool LoadImages { get; set; }

        /// <summary>
        /// Should we enable javascript?
        /// </summary>
        [WkHtmlToPdfResolveTo("enableJavascript")]
        public bool EnableJavascript { get; set; }

        /// <summary>
        /// Should we enable intelligent shrinkng to fit more content on one page?
        /// </summary>
        [WkHtmlToPdfResolveTo("enableIntelligentShrinking")]
        public bool EnableIntelligentShrinking { get; set; }

        /// <summary>
        /// The minimum font size allowed. E.g. 9
        /// </summary>
        [WkHtmlToPdfResolveTo("minimumFontSize")]
        public int MinimumFontSize { get; set; }

        /// <summary>
        /// Should the content be printed using the print media type instead of the screen media type.
        /// </summary>
        [WkHtmlToPdfResolveTo("printMediaType")]
        public bool PrintMediaType { get; set; }

        /// <summary>
        /// What encoding should we guess content is using if they do not specify it properly?
        /// </summary>
        [WkHtmlToPdfResolveTo("defaultEncoding")]
        public PdfEncoding DefaultEncoding { get; set; }

        /// <summary>
        ///  Url er path to a user specified style sheet.
        /// </summary>
        [WkHtmlToPdfResolveTo("userStyleSheet")]
        public string UserStyleSheet { get; set; }

        /// <summary>
        ///  Should we enable NS plugins
        /// </summary>
        [WkHtmlToPdfResolveTo("enablePlugins")]
        public bool EnablePlugins { get; set; }
    }
}
