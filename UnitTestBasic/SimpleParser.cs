using System;
using System.Linq;

namespace UnitTestBasic
{
    public class SimpleParser
    {
        private readonly ILogger _logger;

        public SimpleParser(ILogger logger)
        {
            _logger = logger;
        }

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
                _logger.LogToDb($"input = {numbers}, return = {result}");
                return result;
            }
        }
    }
}
