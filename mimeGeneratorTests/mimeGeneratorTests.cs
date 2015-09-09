using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using MimeGenerator;

namespace MimeGeneratorTests
{
    [TestFixture]
    public class MimeGeneratorTests
    {
        [Test]
        public void getBase64_returnsB64_fromBytes()
        {
            Byte[] input = File.ReadAllBytes("..\\..\\fixtures\\a.txt");
            string result = Generator.getBase64(input);
            Assert.AreEqual("bXl0ZXh0ZmlsZQ==", result);
        }

        [Test]
        public void getMime_returns_imagetext_for_txt()
        {
            string result = Generator.getMime("txt");
            Assert.AreEqual("text/plain", result);
        }
    }
}