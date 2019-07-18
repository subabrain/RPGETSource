using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RPGETv6Beta
{
    class encrypt
    {

        string file = "";
        string folder = "";
        string place = "";
        string name = "";
        string icon = "";
        string encryptedstring = "";
        string folder_gtk = "";
        bool check;
        bool checkc;

        public string get_content_of_file()
        {

            string text = File.ReadAllText(this.file);

            return text;

        }

        public void copy_it()
        {

            string filename = Path.GetFileName(this.file);
            string file = this.file;
            string folder = this.folder;
            this.folder_gtk = folder.Split(Path.DirectorySeparatorChar).Last();
            string place = this.place;

            DirectoryCopy(folder, place + "\\" + this.folder_gtk, true);
            File.Copy(file, place + "\\" + filename, true);

            System.IO.File.WriteAllText("" + place + "\\versch", this.encryptedstring);

        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        public void get_enc()
        {

            string inhalt = this.get_content_of_file();

            this.encryptedstring = Encryptor.Encrypt(inhalt);

        }

        public void set_icon()
        {

            if(this.icon != "")
            {

                System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                pProcess.StartInfo.FileName = @"ResourceHacker.exe";
                pProcess.StartInfo.Arguments = "-open " + this.place + "\\" + this.name + ".exe -save " + this.place + "\\" + this.name + ".exe -action addskip -res " + this.icon + " -mask ICONGROUP,MAINICON,-log NUL "; //argument
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                pProcess.Start();


            }
            
           
        }

        public void get_it(string file, string folder, string icon, string place, string name, bool checkeds, bool checkc)
        {

            this.file = file;
            this.folder = folder;
            this.place = place;
            this.icon = icon;
            this.name = name;
            this.check = checkeds;
            this.checkc = checkc;

        }

        public void set_manifest(string exenamepath, string exename)
        {

            string contents = File.ReadAllText("standard_manifest.txt");
            File.WriteAllText(exename + ".exe.manifest", contents);

            Process myProcess = new Process();

            myProcess.StartInfo.UseShellExecute = false;

            myProcess.StartInfo.FileName = "mt.exe";
            myProcess.StartInfo.Arguments = "/nologo /manifest " + exename + ".exe.manifest -outputresource:" + exenamepath + ".exe;1";
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
            myProcess.WaitForExit();

            if (File.Exists(exename + ".exe.manifest"))
            {
                File.Delete(exename + ".exe.manifest");
            }

           
        }

        public void make_admin_rights()
        {

            if(this.check == true)
            {

                this.set_manifest(this.place + "\\" + this.name, this.name);

            }

        }

        public void compi()
        {

            

            if(this.checkc == true)
            {

                var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v3.5" } });
                var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.dll", "System.Core.dll" }, this.place + "\\" + this.name + ".exe", true);
                parameters.GenerateExecutable = true;

                var instanzen = new Outsource();

                string allesg = instanzen.make_file(this.folder_gtk);

                CompilerResults results = csc.CompileAssemblyFromSource(parameters, allesg);
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));

            } else
            {

                var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v3.5" } });
                var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.dll", "System.Core.dll" }, this.place + "\\" + this.name + ".exe", true);
                parameters.GenerateExecutable = true;

                var instanzen = new Outsource();

                string allesg = instanzen.make_file_with(this.folder_gtk);

                CompilerResults results = csc.CompileAssemblyFromSource(parameters, allesg);
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));

            }


        }


    }

    class Encryptor
    {
        public static string IV = "1a1a1a1a1a1a1a1a";
        //32 zeichen
        public static string Key = "1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a13";

        public static string Encrypt(string decrypted)
        {
            byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(decrypted);
            AesCryptoServiceProvider endec = new AesCryptoServiceProvider();
            endec.BlockSize = 128;
            endec.KeySize = 256;
            endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            endec.Padding = PaddingMode.PKCS7;
            endec.Mode = CipherMode.CBC;
            ICryptoTransform icrypt = endec.CreateEncryptor(endec.Key, endec.IV);
            byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();
            return Convert.ToBase64String(enc);
        }

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

}
