using PR_4;
namespace TestMatrix
{
    [TestClass]
    public class MatrixTests
    {
        int[,] mas;
        [TestInitialize]
        public void SetUp()
        {
            mas = new int[4, 4]
            {
                { 5, 5, 9, 4 },
                { 5, 9, 2, 4 },
                { 5, 2, 2, 6 },
                { 6, 6, 3, 4 }
            };
        }
        [TestMethod]
        public void isSquareTest()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            //bool expected = true;
            // act
            bool actual = matrix.isSquare(mas);
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ToStringTest()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            string expected = "";
            // act
            string actual = matrix.ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RowSumTest()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            int expected = 2;
            // act
            int sum = 0;
            int actual = matrix.RowSum(mas, out sum); 
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RowSumTest1()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            int expected = 19;
            // act
            int actual = matrix.RowSum(mas, 3);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddAmountTest()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            int expected = 1;
            // act
            int actual = matrix.OddAmount(mas,2);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}