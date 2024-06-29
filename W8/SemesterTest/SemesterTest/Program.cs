using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SemesterTest;
class Program
{
    
    static void Main(string[] args)
    {
        MinMaxSummary minmax = new MinMaxSummary();
        AverageSummary average = new AverageSummary();

        //a DataAnalyser object with a list containing the individual digits
        List<int> number = new List<int>() { 1, 0, 4, 1, 7, 7, 3, 9, 3 };
        DataAnalyser data = new DataAnalyser(minmax, number);

        //Call the Summarise method
        data.Summerise();

        //Add three more numbers to the data analyser
        data.Addnumber(5);
        data.Addnumber(9);
        data.Addnumber(3);

        //Set the summary strategy to the average strategy
        data.Strategy = average;

        //Call the Summarise method
        data.Summerise();
        Console.ReadKey();
    }
}
