namespace LibraryTest
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void AreaTriangle1()
        {
            Triangle tri = new Triangle(3,4,5);
            var area = tri.Area();
            var excepted = 6;
            Assert.AreEqual(excepted, area);
        }

        [TestMethod]
        public void AreaTriangle2()
        {
            Triangle tri = new Triangle(12, 13, 5);
            var area = tri.Area();
            var excepted = 30;
            Assert.AreEqual(excepted, area);
        }

        [TestMethod]
        public void IsRightFalse()
        {
            Triangle tri = new Triangle(2, 4, 5);
            bool result = tri.isRightTriangle();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsRightTrue()
        {
            Triangle tri = new Triangle(3, 5, 4);
            bool result = tri.isRightTriangle();
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Сторона треугольника не может быть больше суммы двух других сторон!")]
        public void IsNotTriangle1()
        {
            Triangle c = new Triangle(1, 1, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Сторона треугольника не может быть меньше 0!")]
        public void IsNotTriangle2()
        {
            Triangle c = new Triangle(-1, 1, 0);
        }
    }
}