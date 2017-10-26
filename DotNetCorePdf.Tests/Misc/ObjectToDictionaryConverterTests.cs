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
using DotNetCorePdf.Models;
using DotNetCorePdf.WkHtmlToPdfCore.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
