using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Max_Empty()
        {
            List<int> nums = new List<int>();
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(0));
        }
        [Test]
        public void Max_List()
        {
            List<int> nums = new List<int>() {98, 0, 32, 972, 12, 1024, 50, 8};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(1024));
        }
        [Test]
        public void Max_Beginning()
        {
            List<int> nums = new List<int>() {1398, 972, 12, 1024, 50, 8};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(1398));
        }
        [Test]
        public void Max_End()
        {
            List<int> nums = new List<int>() {98, 972, 12, 1024, 50, 1428};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(1428));
        }
        [Test]
        public void Max_Negative()
        {
            List<int> nums = new List<int>() {98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8};
            int output = MyMath.Operations.Max(nums);
            Assert.That(output, Is.EqualTo(1024));
        }
    }
}