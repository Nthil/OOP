using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" })
        {

        }

        public override string Execute(Player p, string[] text)
        {
            if (!new[] { 3, 5 }.Contains(text.Length))
            {
                return "I don't know how to look like that\n";
            }

            if (text[0] != "look")
            {
                return "Error in look input\n";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?\n";
            }

            if (text.Length == 5)
            {
                string _itemid = text[2];
                string _container = text[4];
                if (text[3] != "in")
                {
                    return "What do you want to look in?\n";
                }

                IHaveInventory container = FetchContainer(p, _container);
                if (container is null)
                {
                    return $"I cannot find the {_itemid} in the {_container}\n";
                }
                return LookAtIn(_itemid, container);
            }

            if (text.Length == 3)
            {
                string _itemid = text[2];
                return LookAtIn(_itemid, p as IHaveInventory);
            }
            return "";
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            if (p.AreYou(containerId))
            {
                return p;
            }
            return (IHaveInventory)p.Locate(containerId);
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                return container.Locate(thingId).FullDescription;
            }

            return $"I cannot find the {thingId}";
        }
    }
}
