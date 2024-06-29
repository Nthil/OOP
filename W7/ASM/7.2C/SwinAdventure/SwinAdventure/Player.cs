using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwinAdventure
{
    public class Player : GameObject, IHaveInventory
    {
        private Location _location;
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

        public Location Location
        {
            get => _location;
            set => _location = value;
        }

        public override string FullDescription
        {
            get { return $"You are {Name}, you are carrying:\n{_inventory.ItemList}"; }
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            GameObject obj = _inventory.Fetch(id);
            if (obj != null)
            {
                return obj;
            }
            if (_location != null)
            {
                obj = _location.Locate(id);
                return obj;
            }
            else
            {
                return null;
            }
        }
    }
    /*
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location;

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id) == true)
            {
                return this;
            }
            if (_inventory.Fetch(id) != null)
            {
                return _inventory.Fetch(id);
            }

            return _location != null ? _location.Locate(id) : null;
        }

        public override string FullDescription
        {
            get
            {
                return $"You are {Name} {base.FullDescription}.\nYou are carrying:\n{Inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Location Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

    }
    */
}
