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
