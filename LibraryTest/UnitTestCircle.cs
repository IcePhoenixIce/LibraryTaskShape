namespace LibraryTest
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void AreaCircle1()
        {
            double r = 3;
            Circle circle = new Circle(r);
            var area = circle.Area();
            var excepted = Math.PI * Math.Pow(r, 2);
            Assert.AreEqual(excepted, area);
        }

        [TestMethod]
        public void AreaCircle2()
        {
            double r = 1.5;
            Circle circle = new Circle(r);
            var area = circle.Area();
            var excepted = Math.PI * Math.Pow(r, 2);
            Assert.AreEqual(excepted, area);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Такого круга не существует! Радиус должен быть положительным и больше 0!")]
        public void IsNotCircle()
        {
            Circle c = new Circle(-1);
        }
    }
}