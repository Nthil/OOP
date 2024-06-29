
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MyProject;
/*
class Pet
{
    string _name, _color;
    int old;
    public virtual string GetSound()
    {
        return "";
    }
}
interface IPet
{
    void Food();
    void Sound();
}

class Cat : Pet, IPet
{
    //public Cat{string name) : base(name){}
    override public string GetSound()
    { return "MeoMeo"; }
    void IPet.Food()
    {
        Console.WriteLine("Fish, pls");
    }
    void IPet.Sound()
    { 
        Console.WriteLine("Meow Meow"); 
    }
}
class Dog : Pet, IPet
{
    override public string GetSound()
    {
        return "Woop Woop";
    }
    void IPet.Food()
    {
        Console.WriteLine("Bone, pls");
    }
    void IPet.Sound() 
    {
        Console.WriteLine("Woof Woof");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //
        //Console.WriteLine("Cat says" + Cat.Pet.Sound());
        //Console.ReadKey();
       
        Cat cat = new Cat();
        IPet Cat = cat;
        Console.WriteLine("Cat says");
        Cat.Food();
        Console.ReadKey();
    }
}
*/
/*
class Test
{
    public delegate void ShowData(string data);
    public void Infor(string data)
    {
        Console.WriteLine("Infor running " + data);
    }
    public void Warning(string data)
    {
        Console.WriteLine("Waring running" + data);
    }
    public void Running()
    {
        ShowData sd;

        sd = Infor;
        sd("Hello");
        sd = Warning;
        sd("World");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Test test = new Test();
        
    }
}
*/

class Program
{
    static void Main(string[] args)
    {
        string _name;
        int _old;
        Console.WriteLine("Enter your name: ");
        _name = Console.ReadLine();
        Console.WriteLine("Enter your birthday year: ");
        _old = int.Parse(Console.ReadLine());
        Console.Write(_name + "," + " youre " + (2023 - _old) + " year-old boss bitch!");
        /* try
        {
            string temp = Console.ReadLine();
            bool isnotno = true;
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] >= '0' && temp[i] <= '9') { }
                else { isnotno = false; }
            if (isnotno == false)
                Console.WriteLine("You put the string. Cannot compute");
            else
            {
                int year = int.Parse(temp);
                Console.Write(_name + "," + "your" + (2023 - year) + "year-old dog bitch");
            }
                /*
            _old = int.Parse(Console.ReadLine());
            Console.Write(_name + "," + "your" + (2023 - _old) + "year-old dog bitch");
                
        }
        catch
        {
            Console.WriteLine("Your have wrong input. Your input is not number");
        }
*/
        //Console.Write(_name + "," + "your" + (2023-_old));
        Console.ReadKey();
    }
}