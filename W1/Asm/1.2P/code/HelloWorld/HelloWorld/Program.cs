// See https://aka.ms/new-console-template for more information
using HelloWorld;
using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    class Program
    {
        public static void Main(string[] args)
        {
            Message myMessage;
            myMessage = new Message("Hello World - from Message Object");
            myMessage.Print();

             Message[] messages = new Message[5];
             string[] names = { "Nguyen", "Chau", "Nhi", "Phuc"};

             messages[0] = new Message("Welcome Back!");
             messages[1] = new Message("What a lovely name");
             messages[2] = new Message("Great name");
             messages[3] = new Message("Oh hi!");
             messages[4] = new Message("That is a silly name");

             Console.WriteLine("Enter Your Name: ");
             string name = Console.ReadLine();
             name = name.ToLower();

             if (name == "Nguyen")
             {
                 messages[0].Print();
             }
             else if (name == "Chau")
             {
                 messages[1].Print();
             }
             else if (name == "Nhi")
             {
                 messages[2].Print();
             }
             else if (name == "Phuc")
             {
                 messages[3].Print();
             }
             else
             {
                 messages[4].Print();
             }
             Console.ReadKey(); 
        }
    }
}
