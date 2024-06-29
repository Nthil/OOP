using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        List<Path> _paths;
        public Location(string name, string desc) : base(new string[] { "location" }, name, desc)
        {
            _inventory = new Inventory();
            _paths = new List<Path>();
        }

        public Location(string name, string desc, List<Path> paths) : this(name, desc)
        {
            _paths = paths;
        }
        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get
            {
                return $"You are at {Name}\nRoom Description: {base.FullDescription}\nIn {Name}, you an see:\n{_inventory.ItemList}";
            }
        }
        public override string ShortDescription
        {
            get
            {
                return "You are in a " + Name;
            }
        }

        public string PathList
        {
            get
            {
                string list = string.Empty + "\n";

                if (_paths.Count == 1)
                {
                    return "There is an exit " + _paths[0].FirstId + ".";
                }

                list = list + "There are exits to the ";

                for (int i = 0; i < _paths.Count; i++)
                {
                    if (i == _paths.Count - 1)
                    {
                        list = list + "and " + _paths[i].FirstId + ".";
                    }
                    else
                    {
                        list = list + _paths[i].FirstId + ", ";
                    }
                }

                return list;
            }
        }
        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
        public void AddPath(Path path)
        {
            _paths.Add(path);
        }
    }
}
