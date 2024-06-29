using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    ////implement the MinMaxSummary to be child classes of the new SummaryStrategy class
    public class MinMaxSummary: SummaryStrategy
    {
        private int Minimum(List<int> numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        private int Maximum(List<int> numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("- The Minimum number:" + Minimum(numbers));
            Console.WriteLine("- The Maximum number:" + Maximum(numbers));
        }
    }
}
