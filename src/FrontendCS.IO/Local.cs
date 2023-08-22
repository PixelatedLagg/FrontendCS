using System;
using System.Runtime.InteropServices;

namespace FrontendCS.IO
{
    public static class Local
    {
        public static void CreateFile(string fileName, string contents)
        {
            VerifyFileName(fileName);
            I_CreateFile(fileName, contents);
        }

        [DllImport("pixel_browser")]
        private static extern void I_CreateFile(string fileName, string contents);

        public static void DeleteFile(string fileName)
        {
            VerifyFileName(fileName);
            I_DeleteFile(fileName);
        }

        [DllImport("pixel_browser")]
        private static extern void I_DeleteFile(string fileName);

        public static void OverwriteFile(string fileName, string contents)
        {
            VerifyFileName(fileName);
            I_OverwriteFile(fileName, contents);
        }

        [DllImport("pixel_browser")]
        private static extern void I_OverwriteFile(string fileName, string contents);

        public static void AppendFile(string fileName, string contents)
        {
            VerifyFileName(fileName);
            I_AppendFile(fileName, contents);
        }

        public static void AppendFileLine(string fileName, string contents) => AppendFile(fileName, $"{Environment.NewLine}{contents}");

        [DllImport("pixel_browser")]
        private static extern void I_AppendFile(string fileName, string contents);

        private static void VerifyFileName(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName))
            {
                throw new Exception("File name must not be null or empty!");
            }
        }
    }
}