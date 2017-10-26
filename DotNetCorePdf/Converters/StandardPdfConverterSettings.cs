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
using DotNetCorePdf.Models;

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
