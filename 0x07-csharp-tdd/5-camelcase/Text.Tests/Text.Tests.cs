using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void CamelCase_Empty()
        {
            string test = "";
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void CamelCase_Single()
        {
            string test = "haa";
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void CamelCase_Words()
        {
            string test = "haHaha";
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void CamelCase_Null()
        {
            string test = null;
            int result = Text.Str.CamelCase(test);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}