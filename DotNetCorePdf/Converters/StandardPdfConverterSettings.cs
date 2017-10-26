using DotNetCorePdf.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Converters
{
    public class StandardPdfConverterSettings
    {
        /// <summary>
        /// Page specific settings. [REQUIRED]
        /// </summary>
        /// <remarks>
        /// REQUIRED
        /// </remarks>
        public PdfConverterGlobalSettings GlobalSettings { get; set; } = new PdfConverterGlobalSettings();

        /// <summary>
        /// Table of contents
        /// </summary>
        public PdfTableOfContents TableOfContents { get; set; } = null;

        /// <summary>
        /// Header specific settings
        /// </summary>
        public PdfHeaderFooter PageHeader { get; set; } = null;

        /// <summary>
        /// Footer specific settings
        /// </summary>
        public PdfHeaderFooter PageFooter { get; set; } = null;

        /// <summary>
        /// Should we turn HTML forms into PDF forms?
        /// </summary>
        public bool ProduceForms { get; set; } = false;

        /// <summary>
        /// Page specific settings related to loading html content
        /// </summary>
        public PdfLoadSettings LoadSettings { get; set; } = null;

        /// <summary>
        /// Webpage behavior settings.
        /// </summary>
        public PdfWebSettings WebSettings { get; set; } = null;

        /// <summary>
        /// Should the sections from this document be included in the outline and table of content? [Requires TableOfContents to be set.]
        /// </summary>
        public bool IncludeInOutline { get; set; } = false;

        /// <summary>
        /// Should we count the pages of this document, in the counter used for TOC, headers and footers? [Requires TableOfContents to be set.]
        /// </summary>
        public bool PagesCount { get; set; }

        /// <summary>
        /// If not empty this object is a table of content object, "page" is ignored and this xsl style sheet is used to convert the outline XML into a table of content. [Requires TableOfContents to be set.]
        /// </summary>
        public string TableOfContentsXsl { get; set; }
    }
}
