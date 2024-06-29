using SwinAdventure;

namespace SwinAdventureTest
{
    public class IdentifiableObjectTest
    {
        private IdentifiableObject _testObject;
        private string _testString;
        private string[] _testArray;

        private IdentifiableObject _testObject_emp;
        private string _testString_emp;
        private string[] _testArray_emp;

        [SetUp]
        public void Setup()
        {
            _testString = "Thi";
            _testArray = new string[] { "Thi", "Nguyen" };
            _testObject = new IdentifiableObject(_testArray);
            _testObject.AddIdentifier(_testString);

            _testString_emp = "";
            _testArray_emp = new string[] { };
            _testObject_emp = new IdentifiableObject(_testArray_emp);
            _testObject_emp.AddIdentifier(_testString_emp);
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_testObject.AreYou(_testString));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_testObject.AreYou("Nhi"));
        }

        [Test]
        public void Insensitive()
        {
            Assert.IsTrue(_testObject.AreYou("THI"));
        }

        [Test]
        public void TestFirstId()
        {
            Assert.AreEqual("thi", _testObject.FirstID);
            Assert.AreNotEqual("nhi", _testObject.FirstID);
        }

        [Test]
        public void TestFirstIdWithNoId()
        {
            Assert.AreEqual("", _testObject_emp.FirstID);
        }

        [Test]
        public void TestAddID()
        {
            _testObject.AddIdentifier("Nhi");
            _testObject.AddIdentifier("Chau");
            Assert.IsTrue(_testObject.AreYou("Nhi"));
            Assert.IsTrue(_testObject.AreYou("Chau"));
        }
    }
}