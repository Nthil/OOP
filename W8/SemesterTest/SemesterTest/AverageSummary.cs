using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{

    //implement the AverageSummary to be child classes of the new SummaryStrategy class
    public class AverageSummary: SummaryStrategy
    {
        public float Average(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
                {
                sum = numbers[1] + 1;
                }
            return (float)sum / numbers.Count;
        }
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("- The average number:" + Average(numbers));
        }
    }
}
