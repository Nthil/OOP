using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
        public class LocationTests
        {
            private Player player;
            private Location myroom;
            private Item gem;
            private Item mora;
            private Item primogem;

            [SetUp]
            public void SetUp()
            {
                player = new Player("Thi", "The Player");

                myroom = new Location(new string[] { "location", "location description" }, $"{player.Name}'s room", $"This is {player.Name}'s room");

                gem = new Item(new string[] { "gem" }, "a gem", "This is a gem");
                mora = new Item(new string[] { "mora" }, "a mora", "This is a mora");
                primogem = new Item(new string[] { "primogem" }, "a primogem", "This is a primogem");
            }

            [Test]
            public void TestLocationIsIdentifiable()
            {
                Assert.IsTrue(this.myroom.AreYou("location"));
            }

            [Test]
            public void TestLocationLocateItems()
            {
                myroom.Inventory.Put(gem);
                myroom.Inventory.Put(mora);
                myroom.Inventory.Put(primogem);

                Assert.That(myroom.Locate("gem"), Is.EqualTo(gem));
                Assert.That(myroom.Locate("mora"), Is.EqualTo(mora));
                Assert.That(myroom.Locate("primogem"), Is.EqualTo(primogem));
            }

            [Test]
            public void TestPlayerLocateItemsInLocation()
            {
                myroom.Inventory.Put(gem);
                myroom.Inventory.Put(mora);
                myroom.Inventory.Put(primogem);

                player.Location = myroom;

                Assert.That(player.Locate("gem"), Is.EqualTo(gem));
                Assert.That(player.Locate("mora"), Is.EqualTo(mora));
                Assert.That(player.Locate("primogem"), Is.EqualTo(primogem));
            }
        }
}
