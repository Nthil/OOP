using NUnitTestDemo;

namespace TestProject1
{
    public class BankAccountTest
    {
        [Test]
        public void Add()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(31, math.Add(20, 11));
        }
        [Test]
        public void Sub()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(10, math.Sub(20, 10));
        }
    }
}