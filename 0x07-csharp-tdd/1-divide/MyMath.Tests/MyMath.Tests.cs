using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
		[Test]
		public void Divide_Even_Matrix()
		{
			int[,] matrix = new int[2, 2] { { 12, 4 }, { 6, 8 } };
			int num = 2;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(new int[2, 2] { { 6, 2 }, { 3, 4 } }, output);
		}
		[Test]
		public void Divide_Null_Matrix()
		{
			int[,] matrix = null;
			int num = 2;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}
		[Test]
		public void Divide_By_Zero()
		{
			int[,] matrix = new int[2, 2] { { 8, 4 }, { 6, 4 } };
			int num = 0;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}
    }
}