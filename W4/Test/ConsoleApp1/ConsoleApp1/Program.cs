// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject;
class Pet  
{
    string _name, _color;
    int _old;

   public virtual string GetSound()  // in the parents class (virtual)
    {
        return "Pet says";
    }
    public void MakeSound()
    {
        Console.WriteLine(_name = "say" + GetSound());
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    public string Old
    {
        set { _old = int.Parse(value); }
        get { return _old.ToString(); }
    }
}
class Cat: Pet
{
    public Cat()
    {
    }
    public override string GetSound() // In the children class (override)
    {
        return "meomeo";
    }
}

class Dog : Pet
{
    public Dog()
    {
    }
    public override string GetSound()
    {
        return "Gogo";
    }
}
/*class Pet
{
    string _name, _color;
    public Pet (string name) { _name = name}
}
*/
/* class Cat
{
    string _name, _color;
    int _old;
    public Cat ()
        {
        }
    public string GetSound()
    {
        return "meomeo";
    }
    public void MakeSound()
    {
        Console.WriteLine(_name = "say" + GetSound());
    }
    public string Name
    {  
        get { return _name; } 
        set { _name = value; }
    }
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    public string Old
    {
        set { _old = Passes(value); }
        get { return _old.ToString(); }
        set { _old = value; }
    }
}
class Dog
{
    string
}
*/


 class Box
{
    int _length, _width, _height;
    
    public int Length
    {
        get { return Length; }
        set { Length = value; }
    }

    public int Width
    {
        get { return Width; }
        set { Width = value; }
    }
    public int Height
    {
        get { return Height; }
        set { Height = value; }
    }
    
    public Box (int _length,  int _width, int _height)
    {
        _length = Length;
        _width = Width;
        _height = Height;
    }
    public double getLength()
    {
        return _length;
    }
    public static Box operator +(Box A, Box B)
    {
        Box box = new Box(0 ,0 , 0);
        box._length = A._length + B._length;
        box._height = A._height + B._height;
        box._width = A._width + B._width;
        return box;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Box Box1 = new Box(3, 4, 5);
        Box Box2 = new Box(6, 7, 8);
        /*
        int Length = Box1.Length() + Box2.Length();
        int Height = Box1.Height() + Box2.Height();
        int Width = Box1.Width() + Box2.Width();
        
        Box NewBox =  new Box(); 
        */
        /*Operater Overloading
         Box A = new Box (1, 2, 3);
        Box B = new Box(2,3,4);
        Box NewBox = A + B
        Console....
         */
        
        Box NewBox = Box1 + Box2; //--> Operater Overloading
        Console.WriteLine("Hello, World!");
    }
}
