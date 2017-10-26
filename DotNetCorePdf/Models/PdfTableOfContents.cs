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
