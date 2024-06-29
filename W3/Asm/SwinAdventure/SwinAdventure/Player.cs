using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwinAdventure
{
    public class Player : GameObject
    {
        private Inventory _inventory;

        public Player(string name, string desc) :
            base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public Inventory Inventory  //Inventory object to manage the players' item
        {
            get => _inventory;
        }

        public override string FullDesciption
        {
            get { return $"You are {Name}, you are carrying:\n" + _inventory.ItemList; }
        }

        public GameObject Locate(string id)  //identify other GameObjects located around the player
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }
    }
}
