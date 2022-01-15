using System;
using System.Linq;

namespace UnitTestBasic
{
    public class SimpleParser
    {
        public bool IsParseAndSumCalled { get; set; }  
        public int ParseAndSum(string numbers)
        {
            IsParseAndSumCalled = true;
            if (numbers.Length == 0)
            {
                return 0;
            }

            if (!numbers.Contains(','))
            {
                return int.Parse(numbers);
            }
            else
            {
                var result = numbers.Split(',').Sum(int.Parse);
                LogToDb(numbers, result);
                return result;
            }
        }

        protected virtual void LogToDb(string numbers, int result)
        {
            Logger.LogToDb($"input = {numbers}, return = {result}");
        }
    }
}
