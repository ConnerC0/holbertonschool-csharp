using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void IsPalindrome_Test()
        {
            string test = "eve";
            Assert.That(Text.Str.IsPalindrome(test), Is.True);
        }
        [Test]
        public void IsPalindrome_Panama()
        {
            string test = "A man, a plan, a canal: Panama.";
            Assert.That(Text.Str.IsPalindrome(test), Is.True);
        }
        [Test]
        public void IsPalindrome_Test2()
        {
            string test = "esve";
            Assert.That(Text.Str.IsPalindrome(test), Is.False);
        }
        [Test]
    }
}