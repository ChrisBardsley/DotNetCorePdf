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
using DotNetCorePdf.WkHtmlToPdfCore.Attributes;

namespace DotNetCorePdf.Models
{
    public class PdfConverterObjectSettings
    {
        /// <summary>
        /// Table of contents settings.
        /// </summary>
        [WkHtmlToPdfResolveTo("toc", NavigateToChildren = true)]
        public PdfTableOfContents TableOfContents { get; set; }

        /// <summary>
        /// The URL or path of the web page to convert, if "-" input is read from stdin.
        /// </summary>
        [WkHtmlToPdfResolveTo("page")]
        public string Page { get; set; }

        /// <summary>
        /// Header specific settings
        /// </summary>
        [WkHtmlToPdfResolveTo("header", NavigateToChildren = true)]
        public PdfHeaderFooter Header { get; set; }

        /// <summary>
        /// Footer specific settings
        /// </summary>
        [WkHtmlToPdfResolveTo("footer", NavigateToChildren = true)]
        public PdfHeaderFooter Footer { get; set; }

        /// <summary>
        /// Should external links in the HTML document be converted into external pdf links?
        /// </summary>
        [WkHtmlToPdfResolveTo("useExternalLinks")]
        public bool UseExternalLinks { get; set; }

        /// <summary>
        /// Should internal links in the HTML document be converted into pdf references?
        /// </summary>
        [WkHtmlToPdfResolveTo("useLocalLinks")]
        public bool UseLocalLinks { get; set; }

        /// <summary>
        /// Should we turn HTML forms into PDF forms?
        /// </summary>
        [WkHtmlToPdfResolveTo("produceForms")]
        public bool ProduceForms { get; set; }

        /// <summary>
        /// Page specific settings related to loading content
        /// </summary>
        [WkHtmlToPdfResolveTo("load", NavigateToChildren = true)]
        public PdfLoadSettings LoadSettings { get; set; }

        /// <summary>
        /// Web specific settings.
        /// </summary>
        [WkHtmlToPdfResolveTo("web", NavigateToChildren = true)]
        public PdfWebSettings WebSettings { get; set; }

        /// <summary>
        /// Should the sections from this document be included in the outline and table of content?
        /// </summary>
        [WkHtmlToPdfResolveTo("includeInOutline")]
        public bool IncludeInOutline { get; set; }

        /// <summary>
        /// Should we count the pages of this document, in the counter used for TOC, headers and footers? Must be using TOC and valid values are true or false
        /// </summary>
        [WkHtmlToPdfResolveTo("pagesCount")]
        public string PagesCount { get; set; }

        /// <summary>
        /// If not empty this object is a table of content object, "page" is ignored and this xsl style sheet is used to convert the outline XML into a table of content.
        /// </summary>
        [WkHtmlToPdfResolveTo("tocXsl")]
        public string TableOfContentsXsl { get; set; }
    }
}
