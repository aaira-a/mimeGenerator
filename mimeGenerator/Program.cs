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
                    Byte[] bytes = File.ReadAllBytes(args[0]);
                    Console.WriteLine(getBase64(bytes));
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
