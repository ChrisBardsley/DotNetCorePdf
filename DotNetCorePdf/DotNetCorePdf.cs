using DotNetCorePdf.Converters;
using DotNetCorePdf.Models;
using DotNetCorePdf.WkHtmlToPdfCore;
using DotNetCorePdf.WkHtmlToPdfCore.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DotNetCorePdf
{
    public class DotNetCorePdf : IDisposable
    {
        #region Private Members
        private bool loaded = false;
        #endregion

        #region Singleton Ctr
        private static volatile DotNetCorePdf instance = null;
        private static object syncRoot = new object();
        private readonly object converterRoot = new object();

        public static DotNetCorePdf Create()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new DotNetCorePdf();
                }
            }
            return instance;
        }

        private DotNetCorePdf()
        {
            loaded = true;
        }
        #endregion

        /// <summary>
        /// Get the current underlying version for wkhtmltopdf.dll
        /// </summary>
        /// <returns>Version String</returns>
        public string WkHtmlToPdfVersion()
        {
            string version = string.Empty;
            version = Marshal.PtrToStringAnsi(WkHtmlToPdfImports.wkhtmltopdf_version());
            return version;
        }

        /// <summary>
        /// Create a pdf converter for converting html string/bytes to pdf.
        /// </summary>
        /// <returns>A string/byte pdf converter</returns>
        public StandardPdfConverter CreateStandardPdfConverter()
        {
            return new StandardPdfConverter(converterRoot);
        }

        /// <summary>
        /// Create a pdf converter for converting html from a Uri such as a system path or Url to pdf.
        /// </summary>
        /// <returns>A Uri pdf converter</returns>
        public UriSourcePdfConverter CreateUriSourcePdfConverter()
        {
            return new UriSourcePdfConverter(converterRoot);
        }

        #region IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        ~DotNetCorePdf()
        {
            // Finalizer calls Dispose(false)  
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
               
            }
            // free native resources if there are any.  
            if (loaded)
            {
                //WkHtmlToPdfImports.wkhtmltopdf_deinit();
            }
        }
        #endregion
    }
}
