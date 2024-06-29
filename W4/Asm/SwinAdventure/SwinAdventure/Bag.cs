using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Bag : Item
    {
        private Inventory _inv;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inv = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            { 
                return this;
            }

            else if (_inv.HasItem(id))
            { 
                return _inv.Fetch(id); 
            }

            return null;
        }

        public override string FullDesciption
        {
            get
            {
                return $"In {this.Name} you can see:\n" + _inv.ItemList;
            }
        }

        public Inventory Inventory
        {
            get => _inv;
        }

    }
}
