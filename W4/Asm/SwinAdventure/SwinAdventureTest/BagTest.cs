using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventureTest
{
    public class TestBag
    {
        Bag b1;
        Bag b2;
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
        Item primogem = new Item(new string[] { "primogem" }, "a primogem", "This is a primogem"); 
        Item mora = new Item(new string[] { "mora" }, "a mora", "This is a mora");


        [SetUp]
        public void Setup()
        {
            //Bag(string[] ids, string name, string desc)
            b1 = new Bag(new string[] { "bag1" }, "the bag 1", "This is the bag 1");
            b2 = new Bag(new string[] { "bag2" }, "the bag 2", "This is the bag 2");
            b1.Inventory.Put(shovel); b1.Inventory.Put(sword); //Add item to bag1
            b2.Inventory.Put(primogem); b2.Inventory.Put(mora); //Add item to bag2


        }

        [Test]
        public void TestBagLocatesItems() //if user can add items to the Bag, and locate the items in its inventory
        {
            Assert.IsTrue(b1.Inventory.HasItem("sword")); //Check if have item
            Assert.IsTrue(b1.Inventory.HasItem("shovel"));

            Assert.IsTrue(b1.Locate(sword.FirstID) == sword); //Check if locate item
            Assert.IsFalse(b1.Locate(shovel.FirstID) == primogem);

        }

        [Test]
        public void TestBagLocateItself() //The bag returns itself if asked to locate one of its identifiers
        {
            Assert.IsTrue(b1.Locate(b1.FirstID) == b1);
            Assert.IsTrue(b1.Locate("bag1") == b1);
        }

        [Test]
        public void TestBagLocateNothing()  //The bag returns a null/nil object if asked to locate something it does not have
        {
            Assert.IsTrue(b1.Locate(primogem.FirstID) == null);
        }

        [Test]
        public void TestBagFullDescription() //The bag's full description contains the text and the short descriptions of the items the bag contains
        {
            Assert.AreEqual(b1.FullDesciption, "In the bag 1 you can see:\na shovel (shovel)\na sword (sword)\n");
        }

        [Test]
        public void TestBagInBag()
        {
            b1.Inventory.Put(b2);
            Assert.IsTrue(b1.Locate(b2.FirstID) == b2); //Test b1 can locate in b2
            Assert.IsFalse(b1.Locate(mora.FirstID) == mora);
            Assert.IsTrue(b1.Locate(shovel.FirstID) == shovel);

            Assert.AreEqual(b1.FullDesciption, "In the bag 1 you can see:\na shovel (shovel)\na sword (sword)\nthe bag 2 (bag2)\n"); //Testing Desc of b
            Assert.AreEqual(b2.FullDesciption, "In the bag 2 you can see:\na primogem (primogem)\na mora (mora)\n"); //Testing Desc of b1


        }

    }
}
