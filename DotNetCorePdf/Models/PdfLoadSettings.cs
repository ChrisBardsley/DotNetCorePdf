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
    public class PdfLoadSettings
    {
        /// <summary>
        /// The user name to use when loging into a website, E.g. "bart"
        /// </summary>
        [WkHtmlToPdfResolveTo("username")]
        public string UserName { get; set; }

        /// <summary>
        /// The password to used when logging into a website, E.g. "elbarto"
        /// </summary>
        [WkHtmlToPdfResolveTo("password")]
        public string Password { get; set; }

        /// <summary>
        /// The mount of time in milliseconds to wait after a page has done loading until it is actually printed. E.g. "1200". We will wait this amount of time or until, javascript calls window.print().
        /// </summary>
        [WkHtmlToPdfResolveTo("jsdelay")]
        public int JsDelay { get; set; }

        /// <summary>
        /// How much should we zoom in on the content? E.g. "2.2".
        /// </summary>
        [WkHtmlToPdfResolveTo("zoomFactor")]
        public string ZoomFactor { get; set; }

        /// <summary>
        /// Should the custom headers be sent all elements loaded instead of only the main page?
        /// </summary>
        [WkHtmlToPdfResolveTo("repeatCustomHeaders")]
        public bool RepeatCustomHeaders { get; set; }

        /// <summary>
        /// Disallow local and piped files to access other local files.
        /// </summary>
        [WkHtmlToPdfResolveTo("blockLocalFileAccess")]
        public bool BlockLocalFileAccess { get; set; }

        /// <summary>
        /// Stop slow running javascript.
        /// </summary>
        [WkHtmlToPdfResolveTo("stopSlowScript")]
        public bool StopSlowScript { get; set; }

        /// <summary>
        /// Forward javascript warnings and errors to the warning callback.
        /// </summary>
        [WkHtmlToPdfResolveTo("debugJavascript")]
        public bool DebugJavascript { get; set; }

        /// <summary>
        /// How should we handle obejcts that fail to load.
        /// </summary>
        [WkHtmlToPdfResolveTo("loadErrorHandling")]
        public LoadErrorHandlingBehavior LoadErrorHandling { get; set; }

        /// <summary>
        /// String describing what proxy to use when loading the object.
        /// </summary>
        [WkHtmlToPdfResolveTo("proxy")]
        public string Proxy { get; set; }
    }
}
