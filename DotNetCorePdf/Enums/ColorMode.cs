using DotNetCorePdf.WkHtmlToPdfCore.Attributes;

namespace DotNetCorePdf.Enums
{
    public enum ColorMode
    {
        /// <summary>
        ///  Output be printed in color
        /// </summary>
        [WkHtmlToPdfResolveTo("Color")]
        Color = 1,
        /// <summary>
        /// Output be printed in grayscale
        /// </summary>
        [WkHtmlToPdfResolveTo("Grayscale")]
        Grayscale = 2
    }
}
