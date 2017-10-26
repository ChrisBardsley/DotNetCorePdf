using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Enums
{
    public enum LoadErrorHandlingBehavior
    {
        /// <summary>
        /// Abort the convertion process
        /// </summary>
        [WkHtmlToPdfResolveTo("abort")]
        Abort = 1,
        /// <summary>
        /// Do not add the object to the final output
        /// </summary>
        [WkHtmlToPdfResolveTo("skip")]
        Skip = 2,
        /// <summary>
        /// Try to add the object to the final output.
        /// </summary>
        [WkHtmlToPdfResolveTo("ignore")]
        Ignore = 3
    }
}
