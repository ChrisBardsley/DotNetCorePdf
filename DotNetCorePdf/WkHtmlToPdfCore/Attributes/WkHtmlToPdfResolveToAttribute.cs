using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.WkHtmlToPdfCore.Attributes
{
    internal class WkHtmlToPdfResolveToAttribute : Attribute
    {
        public string Name { get; set; } = "";
        public bool NavigateToChildren { get; set; }

        public WkHtmlToPdfResolveToAttribute(string name)
        {
            Name = name;
        }
    }
}
