using DotNetCorePdf.WkHtmlToPdfCore.Attributes;

namespace DotNetCorePdf.Enums
{
    public enum Orientation
    {
        /// <summary>
        /// The orientation of the output document. (Landscape)
        /// </summary>
        [WkHtmlToPdfResolveTo("Landscape")]
        Landscape = 1,
        /// <summary>
        /// The orientation of the output document. (Portrait)
        /// </summary>
        [WkHtmlToPdfResolveTo("Portrait")]
        Portrait = 2
    }
}
