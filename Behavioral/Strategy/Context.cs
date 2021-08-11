
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy = null)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = _strategy.DoAlgo(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ',';
            }
            resultStr = resultStr.Remove(resultStr.Length - 1);

            Console.WriteLine(resultStr);
        }
    }
}

