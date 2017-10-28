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
using DotNetCorePdf.Models;
using System;
using System.IO;
using System.Threading;

namespace DotNetCorePdf.Converters
{
    public class UriSourcePdfConverter : PdfConverterBase
    {
        internal UriSourcePdfConverter(object converterRoot)
            :base(converterRoot)
        { }

        /// <summary>
        /// Convert an html webpage to pdf
        /// </summary>
        /// <param name="settings">Page and conversion settings. [REQUIRED]</param>
        /// <param name="uri">The location of the html. Can be a system path or Url.</param>
        /// <returns>byte array containing the pdf data.</returns>
        public byte[] Convert(UriSourceConverterSettings settings, string uri)
        {
            byte[] buffer = new byte[0];

            Uri uriPlug;
            if (!Uri.TryCreate(uri, UriKind.Absolute, out uriPlug))
            {
                if (!File.Exists(uri))
                {
                    throw new ArgumentException(@"Uri must be a Absolute Uri. Examples: http://www.writelinez.com/report.html,   c:\inetpub\mysite\report.html");
                }
            }

            if (!string.IsNullOrEmpty(uri))
            {
                PdfConverterGlobalSettings globalSettings = null;
                PdfConverterObjectSettings objectSettings = null;

                if (settings == null)
                {
                    throw new ArgumentNullException("settings");
                }
                else if (settings.GlobalSettings == null)
                {
                    throw new ArgumentNullException("settings.GlobalSettings");
                }

                globalSettings = settings.GlobalSettings;
                objectSettings = new PdfConverterObjectSettings();

                objectSettings.TableOfContents = settings.TableOfContents;
                objectSettings.Header = settings.PageHeader;
                objectSettings.Footer = settings.PageFooter;
                objectSettings.ProduceForms = settings.ProduceForms;
                objectSettings.LoadSettings = settings.LoadSettings;
                objectSettings.WebSettings = settings.WebSettings;
                objectSettings.UseExternalLinks = settings.UseExternalLinks;
                objectSettings.UseLocalLinks = settings.UseLocalLinks;
                objectSettings.Page = uri;
                if (objectSettings.TableOfContents != null)
                {
                    objectSettings.IncludeInOutline = settings.IncludeInOutline;
                    objectSettings.PagesCount = settings.PagesCount.ToString().ToLower();
                    objectSettings.TableOfContentsXsl = settings.TableOfContentsXsl;
                }

                buffer = ConvertHtmlToPdf(globalSettings, objectSettings);
            }

            return buffer;
        }
    }
}
