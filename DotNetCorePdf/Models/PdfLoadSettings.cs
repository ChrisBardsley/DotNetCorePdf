using DotNetCorePdf.Enums;
using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

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
