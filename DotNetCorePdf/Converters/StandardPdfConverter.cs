using DotNetCorePdf.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Converters
{
    public class StandardPdfConverter : PdfConverterBase
    {
        internal StandardPdfConverter(object converterRoot)
            :base(converterRoot)
        { }

        /// <summary>
        /// Convert an html string to pdf.
        /// </summary>
        /// <param name="settings">Page and conversion settings. [REQUIRED]</param>
        /// <param name="html">html to convert [REQUIRED]</param>
        /// <returns>byte array containing the pdf data.</returns>
        public byte[] Convert(StandardPdfConverterSettings settings, string html)
        {
            byte[] result = new byte[0];
            if (!string.IsNullOrEmpty(html))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(html);
                result = Convert(settings, buffer);
                buffer = null;
            }
            return result;
        }

        /// <summary>
        /// Convert html byte array to pdf.
        /// </summary>
        /// <param name="settings">Page and conversion settings. [REQUIRED]</param>
        /// <param name="htmlBuffer">html to convert [REQUIRED]</param>
        /// <returns>byte array containing the pdf data.</returns>
        public byte[] Convert(StandardPdfConverterSettings settings, byte[] htmlBuffer)
        {
            byte[] buffer = new byte[0];

            if (htmlBuffer != null && htmlBuffer.Length > 0)
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
                if (objectSettings.TableOfContents != null)
                {
                    objectSettings.IncludeInOutline = settings.IncludeInOutline;
                    objectSettings.PagesCount = settings.PagesCount.ToString().ToLower();
                    objectSettings.TableOfContentsXsl = settings.TableOfContentsXsl;
                }

                buffer = ConvertHtmlToPdf(globalSettings, objectSettings, htmlBuffer);
            }

            return buffer;
        }
    }
}
