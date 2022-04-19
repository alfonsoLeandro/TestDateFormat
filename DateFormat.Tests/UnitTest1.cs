using NUnit.Framework;

namespace DateFormat.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestChangeFormatOriginal()
        {
            string original = "13/10/2001";
            string result = Program.ChangeFormat(original);
            string expected = "2001-10-13";
            
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestChangeFormatPart2()
        {
            string original = "13/10/2001";
            string result = Program.ChangeFormat2(original);
            string expected = "13-10-2001";
            
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestChangeFormatPart3()
        {
            string original = "13/10/2001";
            string result = Program.ChangeFormat3(original);
            string expected = "13.10.2001";
            
            Assert.AreEqual(result, expected);
        }
    }
}