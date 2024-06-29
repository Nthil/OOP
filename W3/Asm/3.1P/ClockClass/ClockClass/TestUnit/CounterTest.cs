using ClockClass;
using System.Diagnostics.Metrics;

namespace TestUnit
{
    public class CounterTest
    {
        Counter _ctest;

        [SetUp]
        public void Setup()
        {
            _ctest = new Counter("Test");
        }

        [Test]
        public void test_start0()   //Initialising the counter starts at 0
        {
            Assert.AreEqual(0, _ctest.Tick);
        }

        [Test]
        public void test_count_incre() //Incrementing the counter adds one to the count
        {
            _ctest.Increment();
            Assert.AreEqual(1, _ctest.Tick);
        }

        [TestCase(60, 60)]
        [TestCase(100, 100)]
        public void test_increment(int tick, int result)  //Incrementing the counter multiple times increases the count to match
        {
            int i;
            for (i = 0; i < tick; i++)
            {
                _ctest.Increment();
            }
            Assert.AreEqual(result, _ctest.Tick);
        }

        [Test]
        public void test_count_reset() //Resetting the timer sets the count to 0
        {
            _ctest.Increment();
            _ctest.Reset();
            Assert.AreEqual(0, _ctest.Tick);
        }

    }
}