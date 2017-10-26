using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCorePdf.Tests.PdfConverterTests
{
    [TestClass]
    public class WkHtmlToPdfVersionTest
    {
        [TestMethod]
        public void TestForCorrectVersion()
        {
            string version;
            using (DotNetCorePdf converter = DotNetCorePdf.Create())
            {
                version = converter.WkHtmlToPdfVersion();
            }

            Assert.AreEqual("0.12.4", version);
        }
    }
}
