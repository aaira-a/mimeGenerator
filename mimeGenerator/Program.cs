using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mimeGenerator
{
    public class Generator
    {
        static void Main(string[] args)
        {
        }

        public static string getBase64(Byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
    }
}
