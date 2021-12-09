using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodecTests
{
    [TestClass]
    public class CodecTests
    {

        [TestMethod]
        public void TestString()
        {
            string Expected = "This is a string";
            string s = new string(CodecNS.CodecLibrary.decode(CodecNS.CodecLibrary.encode(Expected)));
            Assert.AreEqual(Expected, s);
        }

        [TestMethod]
        public void TestEncodedString()
        {
            string Expected = "VGhpcyBpcyBhIHRlc3Qgc3RyaW5n";
            string s = new string(CodecNS.CodecLibrary.encode(CodecNS.CodecLibrary.decode(Expected)));
            Assert.AreEqual(Expected, s);
        }


    }
}