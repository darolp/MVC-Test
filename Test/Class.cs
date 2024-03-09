using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MVC_Test.Test
{
    [TestClass]
    public class Class
    {
        [DataRow(4,4,8)]
        [DataRow(5,5,10)]
        [DataRow(6, 4, 10)]
        [DataRow(3, 4, 7)]
        [DataRow(8, 6, 14)]
        [TestMethod]
        public void Sum(int a, int b, int expected)
        {
            //actual
            int actual = Controllers.HomeController.Sum(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
