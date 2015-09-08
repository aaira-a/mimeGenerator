using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace mimeGeneratorTests
{
    [TestFixture]
    public class mimeGeneratorTests
    {
        [Test]
        public void getBase64_returnsB64_fromBytes()
        {
            Byte[] input = File.ReadAllBytes("..\\..\\fixtures\\a.txt");
            string result = mimeGenerator.Generator.getBase64(input);
            Assert.AreEqual("bXl0ZXh0ZmlsZQ==", result);
        }

        [Test]
        public void getMime_returns_imagetext_for_txt()
        {
            string result = mimeGenerator.Generator.getMime("txt");
            Assert.AreEqual("text/plain", result);
        }
    }
}