namespace ShapeAreaCalc.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Test_Area_Method()
        {
            var circle = new Circle() { Radius = 2 };
            var expexted = Math.PI * 4;

            var actual = circle.Area;

            Assert.AreEqual(expexted, actual);
        }
    }
}