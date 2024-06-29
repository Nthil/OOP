using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    //Implement the SummaryStrategy abstract class
    abstract public class SummaryStrategy
    {
        public abstract void PrintSummary(List<int> numbers);
    }
}
