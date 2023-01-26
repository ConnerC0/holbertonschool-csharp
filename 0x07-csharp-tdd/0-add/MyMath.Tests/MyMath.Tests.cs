using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_Two_Positive()
        {
            int a = 90;
            int b = 8;
            int output = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, output);
        }
        [Test]
        public void Add_Positive_Negative()
        {
            int a = -2;
            int b = 100;
            int output = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, output);
        }
        [Test]
        public void Add_Two_Negative()
        {
            int a = -8;
            int b = -90;
            int output = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, output);
        }
    }
}