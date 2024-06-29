// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ClockClass;
class Program
{
    static void Main(string[] args)
    {
        Clock clock = new Clock();
        int i;

        for(i = 0; i < 86400; i++)
        {
            Thread.Sleep(1000);
            Console.Clear();
            clock.Tick();
            Console.WriteLine("Time is counting: " + clock.CurrentTime());
        }
    }
}