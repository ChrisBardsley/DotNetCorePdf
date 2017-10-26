using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf
{
    public class WkHtmlToPdfException : Exception
    {
        public int ErrorCode { get; set; } = -1;

        public WkHtmlToPdfException(string message)
            :base(message)
        { }

        public WkHtmlToPdfException(int errorCode)
            :this(ResolveMessageFromErrorCode(errorCode))
        { }

        private static string ResolveMessageFromErrorCode(int errorCode)
        {
            return "";
        }
    }
}
