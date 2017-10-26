using DotNetCorePdf.Enums;
using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Models
{
    public class PdfConverterGlobalSettings
    {
        /// <summary>
        /// The paper size of the output document
        /// </summary>
        [WkHtmlToPdfResolveTo("size", NavigateToChildren = true)]
        public PdfPageSize Size { get; set; }

        /// <summary>
        /// The orientation of the output document.
        /// </summary>
        [WkHtmlToPdfResolveTo("orientation")]
        public Orientation Orientation { get; set; }

        /// <summary>
        /// Should the output be printed in color or gray scale
        /// </summary>
        [WkHtmlToPdfResolveTo("colorMode")]
        public ColorMode ColorMode { get; set; }

        /// <summary>
        /// Most likely has no effect.
        /// </summary>
        [WkHtmlToPdfResolveTo("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// What dpi should we use when printing, e.g. "80"
        /// </summary>
        [WkHtmlToPdfResolveTo("dpi")]
        public string Dpi { get; set; }

        /// <summary>
        /// A number that is added to all page numbers when printing headers, footers and table of content.
        /// </summary>
        [WkHtmlToPdfResolveTo("pageOffset")]
        public int PageOffset { get; set; }

        /// <summary>
        /// How many copies should we print?. e.g. 2.
        /// </summary>
        [WkHtmlToPdfResolveTo("copies")]
        public int Copies { get; set; }

        /// <summary>
        /// Should the copies be collated?
        /// </summary>
        [WkHtmlToPdfResolveTo("collate")]
        public bool Collate { get; set; }

        /// <summary>
        /// Should a outline (table of content in the sidebar) be generated and put into the PDF?
        /// </summary>
        [WkHtmlToPdfResolveTo("outline")]
        public bool Outline { get; set; }

        /// <summary>
        /// The maximal depth of the outline, e.g. 4.
        /// </summary>
        [WkHtmlToPdfResolveTo("outlineDepth")]
        public int OutlineDepth { get; set; }

        /// <summary>
        /// If not set to the empty string a XML representation of the outline is dumped to this file.
        /// </summary>
        [WkHtmlToPdfResolveTo("dumpOutline")]
        public string DumpOutline { get; set; }

        /// <summary>
        /// The path of the output file, if "-" output is sent to stdout, if empty the output is stored in a buffer.
        /// </summary>
        [WkHtmlToPdfResolveTo("out")]
        public string Out { get; set; }

        /// <summary>
        /// The title of the PDF document.
        /// </summary>
        [WkHtmlToPdfResolveTo("documentTitle")]
        public string DocumentTitle { get; set; }

        /// <summary>
        /// Should we use loss less compression when creating the pdf file?
        /// </summary>
        [WkHtmlToPdfResolveTo("useCompression")]
        public bool UseCompression { get; set; }

        /// <summary>
        /// Margin on page.
        /// </summary>
        [WkHtmlToPdfResolveTo("margin", NavigateToChildren = true)]
        public PdfPageMargin Margin { get; set; }

        /// <summary>
        /// The maximal DPI to use for images in the pdf document.
        /// </summary>
        [WkHtmlToPdfResolveTo("imageDPI")]
        public int ImageDPI { get; set; }

        /// <summary>
        /// The jpeg compression factor to use when producing the pdf document, e.g. 92.
        /// </summary>
        [WkHtmlToPdfResolveTo("imageQuality")]
        public int ImageQuality { get; set; }

        /// <summary>
        /// Path of file used to load and store cookies.
        /// </summary>
        [WkHtmlToPdfResolveTo("load.cookieJar")]
        public string CookiePath { get; set; }
    }
}
