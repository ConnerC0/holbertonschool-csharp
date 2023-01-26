using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void UniqueChar_Nothing()
        {
            string s = "";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void UniqueChar_v()
        {
            string s = "vvvvvvvvvvvvvvvvv";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void UniqueChar_Str()
        {
            string s = "abcdefghijklmnopqrstuvwxyzabcdfghijkzxywvutsrponlm";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        public void UniqueChar_first()
        {
            string s = "wvvvvvvvvvvvvvvvvv";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UniqueChar_last()
        {
            string s = "vvvvvvvvvvvvvvvvvw";
            int result = Text.Str.UniqueChar(s);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}