using DotNetCorePdf.Enums;
using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Models
{
    public class PdfPageSize
    {
        /// <summary>
        /// The paper size of the output document.
        /// </summary>
        [WkHtmlToPdfResolveTo("pageSize")]
        public PageSize PageSize { get; set; }

        /// <summary>
        /// The with of the output document, e.g. "4cm". (Required if setting the PageSize to Custom)
        /// </summary>
        [WkHtmlToPdfResolveTo("width")]
        public string Width { get; set; }

        /// <summary>
        /// The height of the output document, e.g. "12in". (Required if setting the PageSize to Custom)
        /// </summary>
        [WkHtmlToPdfResolveTo("height")]
        public string Height { get; set; }
    }
}
