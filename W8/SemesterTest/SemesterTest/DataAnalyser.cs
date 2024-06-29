using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    public class DataAnalyser
    {
        private List<int> _numbers;
        private SummaryStrategy _strategy; //Modify DataAnalyser to have a private variable, “_strategy”

        public SummaryStrategy Strategy
        {
            get { return _strategy; }
            set { _strategy = value; }
        }

        //allow the strategy to be set through a parameter
        public DataAnalyser (SummaryStrategy strategy) : this(strategy, new List<int>())
        {
        }

        //set the strategy to the average strategy by default (ie. there is no parameters)
        public DataAnalyser() : this(new AverageSummary(), new List<int>())
        {
        }
        public DataAnalyser(List<int> numbers) : this(new AverageSummary(), numbers)
        {
        }
        public DataAnalyser(SummaryStrategy strategy, List<int> numbers)
        {
            _strategy = strategy;
            _numbers = numbers;
        }



        public void Addnumber(int number)
        {
            _numbers.Add(number);
        }


        public void Summerise()
        {
            _strategy.PrintSummary(_numbers);
        }
    }
}
