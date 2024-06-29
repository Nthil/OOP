// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace SwinAdventure;
public class Program
{
    static void Main(string[] args)
    {
        Message greetings;
        greetings = new Message("This is SwinAdventure!!!\nSay 'help' if you need any assistance!\n\nNow, Let's get started!!\n");
        greetings.Print();
        Console.WriteLine("Press to continue...");
        Console.ReadLine();



        // Get the player's name and description from the user, and use these details to create a Player object
        string name, desc;
        Console.Write("\nSetting up player:\nPlayer Name: ");
        name = Console.ReadLine();
        Console.Write("Player Description: ");
        desc = Console.ReadLine();
        Player player = new Player(name, desc);
        Console.Write("\n");
        

        //Set up location

        Location myroom = new Location("My Room", "My room");
        player.Location = myroom; //set up player initial location

        Location garden = new Location("Garden", "Garden");
        Path myroom2garden = new Path(new string[] { "left" }, "Door", "Travel through door", myroom, garden);
        Path garden2myroom = new Path(new string[] { "right" }, "Door", "Travel through door", garden, myroom);
        myroom.AddPath(myroom2garden);
        garden.AddPath(garden2myroom);

        Location livingroom = new Location("Living room", "Living room");
        Path myroom2livingroom = new Path(new string[] { "down" }, "Door", "Travel through door", myroom, livingroom);
        Path livingroom2myroom = new Path(new string[] { "up" }, "Door", "Travel through door", livingroom, myroom);
        myroom.AddPath(myroom2livingroom);
        livingroom.AddPath(livingroom2myroom);

        //The list of items in inventory (bag)
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
        Item diamond = new Item(new string[] { "diamond" }, "a diamond", "This is a diamond");
        Item mora = new Item(new string[] { "mora" }, "a mora", "This is a mora");
        Item gem = new Item(new string[] { "gem" }, "a gem", "This is a gem");
        Item primogem = new Item(new string[] { "primogem" }, "a primogem", "This is a primogem");


        //Set up location items
        myroom.Inventory.Put(primogem);
        garden.Inventory.Put(mora);
        garden.Inventory.Put(gem);


        // Create a bag
        Bag bag = new Bag(new string[] { $"bag" }, $"{player.Name}'s bag", $"This is {player.Name}'s bag");

        //Create two items and add them to the the player's inventory
        player.Inventory.Put(shovel);
        player.Inventory.Put(sword);

        player.Inventory.Put(bag); //Add bag to the player's inventory
        bag.Inventory.Put(diamond);

        // Loop reading commands from the user, and getting the look command to execute them
        string _input;
        Command c = new CommandProcessor();
        Console.WriteLine(c.Execute(player, new string[] { "look" }));

        while (true)
        {
            Console.Write("Command: ");
            _input = Console.ReadLine();

            if (_input.ToLower() != "quit")
            {
                Console.WriteLine(c.Execute(player, _input.Split()));
            }
            else
            {
                Console.WriteLine("Bye");
                Console.ReadKey();
                break;
            }
        }

    }
}
