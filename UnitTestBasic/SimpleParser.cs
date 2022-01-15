using System;

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
                const string message = "I can only handle 0 or 1 numbers now!";
                Logger.LogToDb(message);
                throw new InvalidOperationException(message);
            }
        }
    }
}
