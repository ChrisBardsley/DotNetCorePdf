using DotNetCorePdf.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
