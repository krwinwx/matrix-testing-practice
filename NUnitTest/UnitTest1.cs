using PR_4;
namespace NUnitTest
{
    public class Tests
    {
        int[,] mas;
        [SetUp]
        public void Setup()
        {
            mas = new int[4, 4]
{
                { 5, 5, 9, 4 },
                { 5, 9, 2, 4 },
                { 5, 9, 9, 6 },
                { 6, 6, 3, 4 }
            };
        }
        [Test]
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
        [Test]
        public void ToStringTest()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            string expected = "";
            // act
            string actual = matrix.ToString();
            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void RowSumTest()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            int expected = 2;
            // act
            int sum = 0;
            int actual = matrix.RowSum(mas, out sum);
            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void RowSumTest1()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            int expected = 19;
            // act
            int actual = matrix.RowSum(mas, 3);
            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void OddAmountTest()
        {
            Matrix matrix = new Matrix(4, 4);
            // arrange 
            int expected = 1;
            // act
            int actual = matrix.OddAmount(mas, 2);
            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}