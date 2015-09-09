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

        [TestCase("txt", "text/plain")]
        [TestCase("jpg", "image/jpeg")]
        [TestCase("png", "image/png")]
        [TestCase("json", "application/json")]
        [TestCase("xml", "text/xml")]
        public void getMime_returns_mime_for_extension(string input, string expected)
        {
            string result = Generator.getMime(input);
            Assert.AreEqual(expected, result);
        }
    }
}