using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

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
