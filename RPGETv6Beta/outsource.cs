using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGETv6Beta
{
    class Outsource
    {

        public string make_file(string gtkname)
        {

            string alles = @"using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

namespace Cod
{

    class Cod
    {
        
        [DllImport(""kernel32.dll"")]
        static extern IntPtr GetConsoleWindow();

        [DllImport(""user32.dll"")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main()
        {

            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);

            string readText = File.ReadAllText(""versch"");
            string entsch = Encryptor.Decrypted(readText);

            string tempFile = Path.GetTempFileName();

            File.WriteAllText(tempFile, entsch);

            // Use ProcessStartInfo class.
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = """";
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = ""phpgtk\\php.exe"";
            startInfo.Verb = ""runas"";
            startInfo.Arguments = tempFile;
            var process = Process.Start(startInfo);
            process.WaitForExit();

            Environment.Exit(0);

        }
    }

    class Encryptor
    {
        public static string IV = ""1a1a1a1a1a1a1a1a"";
        //32 zeichen
        public static string Key = ""1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a13"";

        public static string Decrypted(string encrypted)
        {
            byte[] textbytes = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider endec = new AesCryptoServiceProvider();
            endec.BlockSize = 128;
            endec.KeySize = 256;
            endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            endec.Padding = PaddingMode.PKCS7;
            endec.Mode = CipherMode.CBC;
            ICryptoTransform icrypt = endec.CreateDecryptor(endec.Key, endec.IV);
            byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(enc);
        }
    }

}";

            string iss = alles.Replace("\\", "\\\\");
            string sis = iss.Replace("phpgtk", gtkname);
            return sis;

        }


        public string make_file_with(string gtkname)
        {

            string alles = @"using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

namespace Cod
{

    class Cod
    {

        static void Main()
        {

            string readText = File.ReadAllText(""versch"");
            string entsch = Encryptor.Decrypted(readText);

            string tempFile = Path.GetTempFileName();

            File.WriteAllText(tempFile, entsch);

            // Use ProcessStartInfo class.
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = """";
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = true;
            startInfo.FileName = ""phpgtk\\php.exe"";
            startInfo.Verb = ""runas"";
            startInfo.Arguments = tempFile;
            var process = Process.Start(startInfo);
            process.WaitForExit();

            Environment.Exit(0);

        }
    }

    class Encryptor
    {
        public static string IV = ""1a1a1a1a1a1a1a1a"";
        //32 zeichen
        public static string Key = ""1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a13"";

        public static string Decrypted(string encrypted)
        {
            byte[] textbytes = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider endec = new AesCryptoServiceProvider();
            endec.BlockSize = 128;
            endec.KeySize = 256;
            endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            endec.Padding = PaddingMode.PKCS7;
            endec.Mode = CipherMode.CBC;
            ICryptoTransform icrypt = endec.CreateDecryptor(endec.Key, endec.IV);
            byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(enc);
        }
    }

}";

            string iss = alles.Replace("\\", "\\\\");
            string sis = iss.Replace("phpgtk", gtkname);
            return sis;

        }

    }
}

