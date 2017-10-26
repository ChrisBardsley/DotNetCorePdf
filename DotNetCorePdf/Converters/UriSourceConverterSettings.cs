using DotNetCorePdf.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Converters
{
    public class UriSourceConverterSettings : StandardPdfConverterSettings
    {
        /// <summary>
        /// Should external links in the HTML document be converted into external pdf links?
        /// </summary>
        public bool UseExternalLinks { get; set; }

        /// <summary>
        /// Should internal links in the HTML document be converted into pdf references?
        /// </summary>
        public bool UseLocalLinks { get; set; }
    }
}
