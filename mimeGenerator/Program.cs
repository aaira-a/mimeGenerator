using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MimeTypes;

namespace MimeGenerator
{
    public class Generator
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0) 
            {
                if (File.Exists(args[0])) 
                {
                    string fileName = Path.GetFileName(args[0]);
                    string extension = Path.GetExtension(args[0]);

                    Byte[] bytes = File.ReadAllBytes(args[0]);
                    string base64 = getBase64(bytes);
                    string mime = getMime(extension);

                    Console.WriteLine("\nFilename: " + fileName);
                    Console.WriteLine("\nMime: " + mime);
                    Console.WriteLine("\nBase64: \n\n" + base64);
                }
            }
        }

        public static string getBase64(Byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public static string getMime(string extension)
        {
            return MimeTypes.MimeTypeMap.GetMimeType(extension);
        }

    }

}
