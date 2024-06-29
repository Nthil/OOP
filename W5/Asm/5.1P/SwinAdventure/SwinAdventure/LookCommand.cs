using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            IHaveInventory _container;
            string _itemid;
            string error = "Error in look input.";
            //text == look at I in C
            if (text[0].ToLower() != "look") //Check if the first word is “look”
                return error;

            switch (text.Length)
            {
                case 3:    //If there are 3 elements 
                    if (text[1].ToLower() != "at") //Check if the second word is “at”
                        return "What do you want to look at?";
                    _container = (IHaveInventory)p; //the container is the player
                    _itemid = text[2];
                    break;

                case 5:  //If there are 5 elements 
                    _container = FetchContainer(p, text[4]);  //the container id is the 5th word
                    if (_container == null) //Check if container doesn't exist
                        return "Could not find " + text[4];
                    _itemid = text[2];
                    break;

                default:
                    return error;
            }
            return LookAtIn(_itemid, _container);
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
                return container.Locate(thingId).FullDesciption; // "In 'name' you can see: 'item'

            return "Couldn't find " + thingId;    // check if item doesn't exist
        }
    }
}
*/
namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() :
            base(new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            IHaveInventory _container;
            string _itemid;
            string error = "Error in look input.";

            if (text[0].ToLower() != "look")
                return error;

            switch (text.Length)
            {
                case 3:
                    if (text[1].ToLower() != "at")
                        return "What do you want to look at?";
                    _container = (IHaveInventory)p;
                    _itemid = text[2];
                    break;

                case 5:
                    _container = FetchContainer(p, text[4]);
                    if (_container == null)
                        return "Could not find " + text[4];
                    _itemid = text[2];
                    break;

                default:
                    return error;
            }
            return LookAtIn(_itemid, _container);
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
                return container.Locate(thingId).FullDesciption;

            return "Couldn't find " + thingId;
        }
    }
}