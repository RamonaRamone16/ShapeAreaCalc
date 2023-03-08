namespace ShapeAreaCalc.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Test_Add_Method()
        {
            var triangle = new Triangle() { A = 2, B = 3, C = 2 };
            var expexted = Math.Sqrt(3.9375);

            var actual = triangle.Area;

            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void Test_CalcIsRight_Method()
        {
            var triangle = new Triangle() { A = 3, B = 4, C = 5 };

            var actual = triangle.CalcIsRight();

            Assert.AreEqual(true, actual);
        }
    }
}