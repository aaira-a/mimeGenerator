using System;
using System.Collections.Generic;
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
            MM.CreateMessageWithAttachment();
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
