using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventureTest
{
    internal class LocationTest
    {
        Player p = new Player("Thi", "This is Thi");
        Location l = new Location("MyRoom", "This is my room");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestLookCommand()
        {
            p.Location = l;
            bool actual = l.AreYou("location");
            Assert.IsTrue(actual);
        }

        [Test]
        public void TestNotLookCommand()
        {
            p.Location = l;
            bool actual = l.AreYou("Thi");
            Assert.IsFalse(actual);
        }

        [Test]
        public void TestPLayerHasLocation()
        {
            p.Location = l;
            GameObject expect = l;
            GameObject actual = p.Locate("location");
            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void TestLocationLocateItem()
        {
            l.Inventory.Put(sword);
            GameObject expect = sword;
            GameObject actual = l.Locate("sword");
            Assert.AreEqual(actual, expect);
        }
    }
}
