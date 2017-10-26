using DotNetCorePdf.WkHtmlToPdfCore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCorePdf.Enums
{
    public enum PdfEncoding
    {
        /// <summary>
        /// A character in UTF8 can be from 1 to 4 bytes long. UTF-8 can represent any character in the Unicode standard. UTF-8 is backwards compatible with ASCII. UTF-8 is the preferred encoding for e-mail and web pages.
        /// </summary>
        [WkHtmlToPdfResolveTo("utf-8")]
        UTF8 = 1,
        /// <summary>
        /// defines a unique binary 7-bits number for each storable character to support the numbers from 0-9, the upper/lower case English alphabet (a-z, A-Z), and some special characters like ! $ + - ( ) @ < > 
        /// </summary>
        [WkHtmlToPdfResolveTo("ascii")]
        ASCII = 2,
        /// <summary>
        /// The Unicode Standard covers (almost) all the characters, punctuations, and symbols in the world.
        /// </summary>
        [WkHtmlToPdfResolveTo("unicode")]
        Unicode = 3,
        /// <summary>
        /// UTF-32 is a fixed-length encoding, in contrast to all other Unicode transformation formats, which are variable-length encodings. Each 32-bit value in UTF-32 represents one Unicode code point and is exactly equal to that code point's numerical value.
        /// </summary>
        [WkHtmlToPdfResolveTo("utf-32")]
        UTF32 = 4,
        /// <summary>
        /// UTF-7 is a variable-length character encoding that was proposed for representing Unicode text using a stream of ASCII characters. It was originally intended to provide a means of encoding Unicode text for use in Internet E-mail messages that was more efficient than the combination of UTF-8 with quoted-printable.
        /// </summary>
        [WkHtmlToPdfResolveTo("utf-7")]
        UTF7 = 5,
        /// <summary>
        /// Gets an encoding for the UTF-16 format that uses the big endian byte order.
        /// </summary>
        [WkHtmlToPdfResolveTo("utf-16")]
        BigEndianUnicode = 6
    }
}
