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
        static void LookCommandExe(Command l, string input, Player player)
        {
            Console.WriteLine(l.Execute(player, input.Split()));

        }

        static void Main(string[] args)
        {
            //Greeting with information 
            string name, desc;
            string help = "Error with:\n-look\n\nGetting Information:\n-look at me (show player's details and items)\n-look at bag (show items in player's bag)\n\nGetting item description:\nlook at {item}\nlook at {item} in me\nlook at {item} in bag\nType 'quit' to log out\n\n";

            Message greetings;
            greetings = new Message("This is SwinAdventure!!!\nSay 'help' if you need any assistance!\n\nNow, Let's get started!!\n");
            greetings.Print();
            Console.WriteLine("Press to continue...");
            Console.ReadLine();

            //Get the player's name and description from the user --> create objects

            Console.Write("Setting up player:\nPlayer Name: ");
            name = Console.ReadLine();
            Console.Write("Player Description: ");
            desc = Console.ReadLine();
            Player player = new Player(name, desc);

            //The list of items in inventory (bag)

            Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
            Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
            Item diamond = new Item(new string[] { "diamond" }, "a diamond", "This is a diamond");
            //Create a bag
            Bag bag = new Bag(new string[] { $"bag" }, $"{player.Name}'s bag", $"This is {player.Name}'s bag");
            //Create two items and add them to the the player's inventory
            player.Inventory.Put(shovel); 
            player.Inventory.Put(sword);
            player.Inventory.Put(bag); //Add bag to the player's inventory
            bag.Inventory.Put(diamond);

            //Proccessing input command
            string _input;
            Command l = new LookCommand();

            while (true)
            {
                Console.Write("Command: ");
                _input = Console.ReadLine();
                if (_input == "quit")
                {
                    break;
                }
                else if (_input == "help")
                {
                    Console.Write(help);
                }
                else
                {
                    LookCommandExe(l, _input, player);
                }

            }
        }
    }
}
