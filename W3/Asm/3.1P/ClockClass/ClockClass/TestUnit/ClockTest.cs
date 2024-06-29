using ClockClass;
using System.Diagnostics.Metrics;

namespace TestUnit
{
    public class ClockTest
    {
        Clock _clock;

        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }

        [Test]
        public void test_start()
        {
            Assert.AreEqual("00:00:00", _clock.CurrentTime());
        }

        [Test]
        public void test_reset()
        {
            int i;
            for (i = 0; i < 86400; i++)
            {
                _clock.Tick();
            }
            _clock.Reset();
            Assert.AreEqual("00:00:00", _clock.CurrentTime());

        }

        [TestCase(0, "00:00:00")]
        [TestCase(60, "00:01:00")]
        [TestCase(3600, "01:00:00")]
        [TestCase(86340, "23:59:00")]

        public void TestRunning(int tick, string currenttime)
        {
            int i;
            for (i = 0; i < tick; i++)
            {
                _clock.Tick();
            }
            Assert.AreEqual(currenttime, _clock.CurrentTime());

        }

    }
}
