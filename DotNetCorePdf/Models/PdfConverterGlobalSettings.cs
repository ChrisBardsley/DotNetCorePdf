/*
MIT License

Copyright (c) 2017 WriteLinez L.L.C.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */
using DotNetCorePdf.Enums;
using DotNetCorePdf.WkHtmlToPdfCore.Attributes;

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
