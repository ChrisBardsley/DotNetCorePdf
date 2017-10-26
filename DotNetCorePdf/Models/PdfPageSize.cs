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
