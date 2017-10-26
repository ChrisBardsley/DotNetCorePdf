using DotNetCorePdf.Converters;
using DotNetCorePdf.Enums;
using DotNetCorePdf.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCorePdf.Tests.PdfConverterTests
{
    [TestClass]
    public class WkHtmlToPdfConvertHtmlToPdfTests
    {
        [TestMethod]
        public void ConvertBytesSuccess()
        {
            byte[] resultBuffer = null;
            string htmlString = @"<html><head><title>Test Page</title></head><body><b>I am the one and only PDF.</b><p>You know you like it!!!</p></body></html>";
            byte[] htmlBuffer = Encoding.UTF8.GetBytes(htmlString);

            StandardPdfConverterSettings settings = new StandardPdfConverterSettings();
            settings.GlobalSettings = new PdfConverterGlobalSettings();
            settings.GlobalSettings.Copies = 1;
            settings.GlobalSettings.DocumentTitle = "YaYa!!!";
            settings.GlobalSettings.Orientation = Orientation.Portrait;

            DotNetCorePdf pdf = DotNetCorePdf.Create();
            using (StandardPdfConverter pdfConverter = pdf.CreateStandardPdfConverter())
            {
                resultBuffer = pdfConverter.Convert(settings, htmlBuffer);
            }

            Assert.IsTrue(resultBuffer != null && resultBuffer.Length > 0);
        }

        [TestMethod]
        public void ConvertBytesWithMultipleThreads()
        {
            BlockingCollection<byte[]> dta = new BlockingCollection<byte[]>();
            int threadIterations = 50;
            byte[] resultBuffer = null;
            string htmlString = @"<html><head><title>Test Page</title></head><body><b>COUNTER: {0}</b></body></html>";

            StandardPdfConverterSettings settings = new StandardPdfConverterSettings();
            settings.GlobalSettings = new PdfConverterGlobalSettings();
            settings.GlobalSettings.Copies = 1;
            settings.GlobalSettings.DocumentTitle = "YaYa!!!";
            settings.GlobalSettings.Orientation = Orientation.Portrait;

            DotNetCorePdf pdf = DotNetCorePdf.Create();
            Parallel.For(0, threadIterations, index =>
            {
                string ns = string.Format(htmlString, index);
                byte[] htmlBuffer = Encoding.UTF8.GetBytes(ns);

                using (StandardPdfConverter pdfConverter = pdf.CreateStandardPdfConverter())
                {
                    resultBuffer = pdfConverter.Convert(settings, htmlBuffer);
                    dta.Add(resultBuffer);
                }
            });

            Assert.AreEqual(threadIterations, dta.Count);
            Assert.IsTrue(dta.All(t => t.Length > 0));
        }

        [TestMethod]
        public void ConvertStringSuccess()
        {
            byte[] resultBuffer = null;
            string htmlString = @"<html><head><title>Test Page</title></head><body><b>I am the one and only PDF.</b><p>You know you like it!!!</p></body></html>";

            StandardPdfConverterSettings settings = new StandardPdfConverterSettings();
            settings.GlobalSettings = new PdfConverterGlobalSettings();
            settings.GlobalSettings.Copies = 1;
            settings.GlobalSettings.DocumentTitle = "YaYa!!!";
            settings.GlobalSettings.Orientation = Orientation.Portrait;

            DotNetCorePdf pdf = DotNetCorePdf.Create();
            using (StandardPdfConverter pdfConverter = pdf.CreateStandardPdfConverter())
            {
                resultBuffer = pdfConverter.Convert(settings, htmlString);
            }

            Assert.IsTrue(resultBuffer != null && resultBuffer.Length > 0);
        }

        [TestMethod]
        public void ConvertStringWithMultipleThreads()
        {
            BlockingCollection<byte[]> dta = new BlockingCollection<byte[]>();
            int threadIterations = 50;
            byte[] resultBuffer = null;
            string htmlString = @"<html><head><title>Test Page</title></head><body><b>COUNTER: {0}</b></body></html>";

            StandardPdfConverterSettings settings = new StandardPdfConverterSettings();
            settings.GlobalSettings = new PdfConverterGlobalSettings();
            settings.GlobalSettings.Copies = 1;
            settings.GlobalSettings.DocumentTitle = "YaYa!!!";
            settings.GlobalSettings.Orientation = Orientation.Portrait;

            DotNetCorePdf pdf = DotNetCorePdf.Create();
            Parallel.For(0, threadIterations, index =>
            {
                string ns = string.Format(htmlString, index);

                using (StandardPdfConverter pdfConverter = pdf.CreateStandardPdfConverter())
                {
                    resultBuffer = pdfConverter.Convert(settings, htmlString);
                    dta.Add(resultBuffer);
                }
            });

            Assert.AreEqual(threadIterations, dta.Count);
            Assert.IsTrue(dta.All(t => t.Length > 0));
        }

        [TestMethod]
        public void ConvertUrlToPdfWithSuccess()
        {
            byte[] resultBuffer = null;
            string url = "http://writelinez.com";

            UriSourceConverterSettings settings = new UriSourceConverterSettings();
            settings.GlobalSettings = new PdfConverterGlobalSettings();
            settings.GlobalSettings.Copies = 1;
            settings.GlobalSettings.DocumentTitle = "YaYa!!!";
            settings.GlobalSettings.Orientation = Orientation.Portrait;
            settings.WebSettings = new PdfWebSettings();
            settings.WebSettings.LoadImages = true;
            settings.WebSettings.Background = true;

            DotNetCorePdf pdf = DotNetCorePdf.Create();

            using (UriSourcePdfConverter converter = pdf.CreateUriSourcePdfConverter())
            {
                resultBuffer = converter.Convert(settings, url);
            }

            using (FileStream fs = new FileStream(@"c:\temp\writelinez.pdf", FileMode.Create))
            {
                fs.Write(resultBuffer, 0, resultBuffer.Length);
            }
        }

        [TestMethod]
        public void ConvertFilePathToPdfWithSuccess()
        {
            byte[] resultBuffer = null;
            string path = @"c:\temp\testFile.html";

            if (!File.Exists(path))
            {
                string html = "<html><head><title>Test Page</title></head><body><b>I am the one and only PDF.</b><p>You know you like it!!!</p></body></html>";
                byte[] htmlBytes = Encoding.UTF8.GetBytes(html);
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    fs.Write(htmlBytes, 0, htmlBytes.Length);
                }
            }

            UriSourceConverterSettings settings = new UriSourceConverterSettings();
            settings.GlobalSettings = new PdfConverterGlobalSettings();
            settings.GlobalSettings.Copies = 1;
            settings.GlobalSettings.DocumentTitle = "YaYa!!!";
            settings.GlobalSettings.Orientation = Orientation.Portrait;
            settings.WebSettings = new PdfWebSettings();
            settings.WebSettings.LoadImages = true;
            settings.WebSettings.Background = true;

            DotNetCorePdf pdf = DotNetCorePdf.Create();

            using (UriSourcePdfConverter converter = pdf.CreateUriSourcePdfConverter())
            {
                resultBuffer = converter.Convert(settings, path);
            }

            using (FileStream fs = new FileStream(@"c:\temp\testFile.pdf", FileMode.Create))
            {
                fs.Write(resultBuffer, 0, resultBuffer.Length);
            }
        }
    }
}
