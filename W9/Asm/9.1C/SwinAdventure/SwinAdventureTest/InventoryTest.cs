using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class TestInventory
    {
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");

        [Test]
        public void TestFindItem() //The Inventory has items that are put in it
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.IsTrue(i.HasItem(shovel.FirstId));
        }

        [Test]
        public void TestNoItemFind() //The Inventory does not have items it does not contain.
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.IsFalse(i.HasItem(sword.FirstId));
        }

        [Test]
        public void TestFetchItem() //Returns items it has, and the item remains in the inventory.
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Item fetchItem = i.Fetch(shovel.FirstId);

            Assert.IsTrue(fetchItem == shovel);
            Assert.IsTrue(i.HasItem(shovel.FirstId));
        }

        [Test]
        public void TestTakeItem()  //Returns the item, and the item is no longer in the inventory (item is taken)
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Take(shovel.FirstId);
            Assert.IsFalse(i.HasItem(shovel.FirstId));
        }

        [Test]
        public void TestItemList() //Returns a string containing multiple lines.
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Put(sword);
            Assert.IsTrue(i.HasItem(shovel.FirstId));
            Assert.IsTrue(i.HasItem(sword.FirstId));

            string expctOutput = "a shovel (shovel)\n" + "a sword (sword)\n";
            Assert.AreEqual(i.ItemList, expctOutput);
        }

    }
}
