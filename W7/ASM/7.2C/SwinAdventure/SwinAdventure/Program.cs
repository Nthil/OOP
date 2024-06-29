// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace SwinAdventure
{
    public class Program
    {
        public static void Main()
        {

            Message greetings;
            greetings = new Message("This is SwinAdventure!!!\nSay 'help' if you need any assistance!\n\nNow, Let's get started!!\n");
            greetings.Print();
            Console.WriteLine("Press to continue...");
            Console.ReadLine();

            // Get the player's name and description from the user, and use these details to create a Player object

            string _name, _description;
            Console.WriteLine("Player name:");
            _name = Console.ReadLine();

            Console.WriteLine("Player description:");
            _description = Console.ReadLine();

            Player player = new Player(_name, _description);


            //The list of items in inventory (bag)
            Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
            Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
            Item diamond = new Item(new string[] { "diamond" }, "a diamond", "This is a diamond");
            Item mora = new Item(new string[] { "mora" }, "a mora", "This is a mora");
            Item gem = new Item(new string[] { "gem" }, "a gem", "This is a gem");
            Item primogem = new Item(new string[] { "primogem" }, "a primogem", "This is a primogem");

            // Create a bag
            Bag bag = new Bag(new string[] { $"bag" }, $"{player.Name}'s bag", $"This is {player.Name}'s bag");

            //Create two items and add them to the the player's inventory
            player.Inventory.Put(shovel);
            player.Inventory.Put(sword);

            player.Inventory.Put(bag); //Add bag to the player's inventory
            bag.Inventory.Put(diamond);

            //Set up location
            Location myroom = new Location(new string[] { "location", "location description" }, $"{player.Name}'s room", $"This is {player.Name}'s room");
            player.Location = myroom;


            //Set up location items
            myroom.Inventory.Put(gem);
            myroom.Inventory.Put(mora);
            myroom.Inventory.Put(primogem);


            // Loop reading commands from the user, and getting the look command to execute them
            while (true)
            {
                string _input;
                LookCommand _command = new LookCommand();
                Console.WriteLine("Enter command: ");
                _input = Console.ReadLine();

                if (_input == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(_command.Execute(player, _input.Split(' ')));

                }
            }
        }
    }
}
