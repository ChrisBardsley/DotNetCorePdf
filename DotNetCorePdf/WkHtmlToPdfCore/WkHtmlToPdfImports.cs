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
using DotNetCorePdf.WkHtmlToPdfCore.Utils;
using System;
using System.Runtime.InteropServices;

namespace DotNetCorePdf.WkHtmlToPdfCore
{
    internal unsafe static class WkHtmlToPdfImports
    {
        const string DLLNAME = "libwkhtmltox";

        const CharSet CHARSET = CharSet.Unicode;

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_extended_qt();

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_version();

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_init(int useGraphics);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_deinit();

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_global_settings();

        [DllImport(DLLNAME, CharSet = CHARSET)]
        public static extern int wkhtmltopdf_set_global_setting(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string value);


        [DllImport(DLLNAME, CharSet = CHARSET)]
        public static unsafe extern int wkhtmltopdf_get_global_setting(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            byte* value, int valueSize);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_destroy_global_settings(IntPtr settings);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_object_settings();

        [DllImport(DLLNAME, CharSet = CHARSET)]
        public static extern int wkhtmltopdf_set_object_setting(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string value);

        [DllImport(DLLNAME, CharSet = CHARSET)]
        public static unsafe extern int wkhtmltopdf_get_object_setting(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            byte* value, int valueSize);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_destroy_object_settings(IntPtr settings);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_converter(IntPtr globalSettings);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_add_object(IntPtr converter,
            IntPtr objectSettings,
            byte[] data);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_add_object(IntPtr converter,
            IntPtr objectSettings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)] string data);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool wkhtmltopdf_convert(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_destroy_converter(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_get_output(IntPtr converter, out IntPtr data);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_phase_changed_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] VoidCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_progress_changed_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] VoidCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_finished_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] IntCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_warning_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] StringCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_error_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] StringCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_phase_count(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_current_phase(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_phase_description(IntPtr converter, int phase);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_progress_string(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_http_error_code(IntPtr converter);
    }
}
