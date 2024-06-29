// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Test;

namespace MyProject;
class Counter
{
    int _count;
    string _name; 
    
    public Counter(string name)
    {
        _name = name;
    }
    public void Increment()
    {

    }
    public void Reset()
    {

    }
    public String Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int Ticks
    {
        get { return _count; }
    }
    static void Main(string[] args)
    {
        Counter ct = new Counter("Long");
        Console.WriteLine(ct.Name);//Get
        ct.Name = "Quynh"; //Set
        Console.WriteLine(ct.Name);
        Console.ReadKey();
    }
}