using DotNetCorePdf.WkHtmlToPdfCore.Attributes;

namespace DotNetCorePdf.Enums
{
    public enum PageSize
    {
        /// <summary>
        /// Custom Size. (Requires setting width and height settings)
        /// </summary>
        [WkHtmlToPdfResolveTo("Custom")]
        Custom = 0,
        /// <summary>
        /// 33.1 x 46.8 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A0")]
        A0 = 1,
        /// <summary>
        /// 23.4 x 33.1 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A1")]
        A1 = 2,
        /// <summary>
        /// 16.5 x 23.4 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A2")]
        A2 = 3,
        /// <summary>
        /// 11.7 x 16.5 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A3")]
        A3 = 4,
        /// <summary>
        /// 8.3 x 11.7 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A4")]
        A4 = 5,
        /// <summary>
        /// 5.8 x 8.3 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A5")]
        A5 = 6,
        /// <summary>
        /// 4.1 x 5.8 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A6")]
        A6 = 7,
        /// <summary>
        /// 2.9 x 4.1 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A7")]
        A7 = 8,
        /// <summary>
        /// 2.0 x 2.9 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A8")]
        A8 = 9,
        /// <summary>
        /// 1.5 x 2.0 in
        /// </summary>
        [WkHtmlToPdfResolveTo("A9")]
        A9 = 10,
        /// <summary>
        /// 39.4 x 55.7 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B0")]
        B0 = 11,
        /// <summary>
        /// 27.8 x 39.4 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B1")]
        B1 = 12,
        /// <summary>
        /// 1.2 x 1.7 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B10")]
        B10 = 13,
        /// <summary>
        /// 19.7 x 27.8 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B2")]
        B2 = 14,
        /// <summary>
        /// 13.9 x 19.7 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B3")]
        B3 = 15,
        /// <summary>
        /// 9.8 x 13.9 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B4")]
        B4 = 16,
        /// <summary>
        /// 6.9 x 9.8 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B5")]
        B5 = 17,
        /// <summary>
        /// 4.9 x 6.9 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B6")]
        B6 = 18,
        /// <summary>
        /// 3.5 x 4.9 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B7")]
        B7 = 19,
        /// <summary>
        /// 2.4 x 3.5 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B8")]
        B8 = 20,
        /// <summary>
        /// 1.7 x 2.4 in
        /// </summary>
        [WkHtmlToPdfResolveTo("B9")]
        B9 = 21,
        /// <summary>
        /// 6.4 x 9.0 in
        /// </summary>
        [WkHtmlToPdfResolveTo("C5E")]
        C5E = 22,
        /// <summary>
        /// 1.1 x 1.6 in
        /// </summary>
        [WkHtmlToPdfResolveTo("Comm10E")]
        Comm10E = 23,
        /// <summary>
        ///
        /// </summary>
        [WkHtmlToPdfResolveTo("DLE")]
        DLE = 24,
        /// <summary>
        ///
        /// </summary>
        [WkHtmlToPdfResolveTo("Executive")]
        Executive = 25,
        /// <summary>
        ///
        /// </summary>
        [WkHtmlToPdfResolveTo("Folio")]
        Folio = 26,
        /// <summary>
        /// 11 × 17 in
        /// </summary>
        [WkHtmlToPdfResolveTo("Ledger")]
        Ledger = 27,
        /// <summary>
        /// 8.5 × 14.0 in
        /// </summary>
        [WkHtmlToPdfResolveTo("Legal")]
        Legal = 28,
        /// <summary>
        /// 8.5 × 11 in
        /// </summary>
        [WkHtmlToPdfResolveTo("Letter")]
        Letter = 29,
        /// <summary>
        ///
        /// </summary>
        [WkHtmlToPdfResolveTo("Tabloid")]
        Tabloid = 30
    }
}
