using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class TestPlayer
    {
        Player player = new Player("Thi", "the programmer");
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a Sword");

        [Test]
        public void TestPlayerIdentifiable() //The player responds correctly to "Are You" requests based on its defidentifiers
        {
            Assert.IsTrue(player.AreYou("me") && player.AreYou("inventory"));
        }

        [Test]
        public void TestPlayerLocatesItems() //The player can locate items in its inventory
        {
            var result = false;
            player.Inventory.Put(sword);
            var itemsLocated = player.Locate("sword");
            if (sword == itemsLocated)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void TestPlayerLocatesItself() //The player returns itself if asked to locate "me" or "inventory"
        {
            var me = player.Locate("me");
            var inv = player.Locate("inventory");
            var result = false;

            if (me == player || inv == player)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void TestPlayerLocatesNothing() //The player returns a null/nil object if asked to locate something it does
        {
            var me = player.Locate("Hi");
            Assert.IsNull(me);
        }

        [Test]
        public void TestPlayerFullDescription() //The player's full description contains the correct text
        {
            player.Inventory.Put(sword);
            player.Inventory.Put(shovel);
            string expected = $"You are {player.Name}, you are carrying:\n{player.Inventory.ItemList}";
            Assert.AreEqual(player.FullDesciption, expected);
        }
    }
}
