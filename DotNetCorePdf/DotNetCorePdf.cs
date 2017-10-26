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
using DotNetCorePdf.Converters;
using DotNetCorePdf.WkHtmlToPdfCore;
using System;
using System.Runtime.InteropServices;

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
