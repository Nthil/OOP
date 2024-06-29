using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class TestItem
    {
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");


        [Test]
        public void TestItemIdentifiable() //Check the request "Are You" based on the identifiables 
        {
            var result = shovel.AreYou("sword");
            Assert.IsFalse(result); //Item does not match 

            var result2 = shovel.AreYou("shovel");
            Assert.IsTrue(result2); //Item matches
        }

        [Test]
        public void TestShortDescription() //Test if the short des is correct
        {
            Assert.AreEqual(shovel.ShortDescription, "a shovel (shovel)"); //If yes
            Assert.AreNotEqual(shovel.ShortDescription, "This is a shovel"); //If no
        }

        [Test]
        public void TestFullDescription() //Test if the full des is correct
        {
            Assert.AreEqual(shovel.FullDescription, "This is a shovel"); //If yes
            Assert.AreNotEqual(shovel.FullDescription, "a shovel (shovel)"); //If no
        }
    }
}
