using DotNetCorePdf.Enums;
using DotNetCorePdf.Models;
using DotNetCorePdf.WkHtmlToPdfCore.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Tests.Misc
{
    [TestClass]
    public class ObjectToDictionaryConverterTests
    {
        [TestMethod]
        public void SimplePassTest()
        {
            PdfConverterGlobalSettings settings = new PdfConverterGlobalSettings();
            settings.Collate = false;
            settings.ColorMode = ColorMode.Grayscale;
            settings.Copies = 5;
            settings.DocumentTitle = "Bojangles";
            settings.Margin = new PdfPageMargin()
            {
                Bottom = "2cm",
                Top = "4cm",
                Left = "4cm",
                Right = "2cm"
            };
            settings.Orientation = Orientation.Portrait;
            settings.UseCompression = false;

            Dictionary<string, string> strObj = ObjectToDictionaryConverter.Convert(settings);

            var Collate = strObj["collate"];
            var _ColorMode = strObj["colorMode"];
            var Copies = strObj["copies"];
            var DocumentTitle = strObj["documentTitle"];
            var MarginBottom = strObj["margin.bottom"];
            var MarginTop = strObj["margin.top"];
            var MarginLeft = strObj["margin.left"];
            var MarginRight = strObj["margin.right"];
            var _Orientation = strObj["orientation"];
            var UseCompression = strObj["useCompression"];

            Assert.AreEqual("false", Collate);
            Assert.AreEqual("Grayscale", _ColorMode);
            Assert.AreEqual("5", Copies);
            Assert.AreEqual("Bojangles", DocumentTitle);
            Assert.AreEqual("2cm", MarginBottom);
            Assert.AreEqual("4cm", MarginTop);
            Assert.AreEqual("4cm", MarginLeft);
            Assert.AreEqual("2cm", MarginRight);
            Assert.AreEqual("Portrait", _Orientation);
            Assert.AreEqual("false", UseCompression);
        }
    }
}
