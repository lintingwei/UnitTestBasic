using NUnit.Framework;

namespace UnitTestBasic.Test
{
    public class SimpleParserTest
    {
        private SimpleParser _parser;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            _parser = new FakeSimpleParser();
        }

        [TestCase("0", 0, TestName = "Should return 0")]
        [TestCase("1,2", 3, TestName = "Should return 3")]
        // Verify return value
        public void SimpleParser_Should_Return_0(string numbers, int expected)
        {
            // Act
            var result = CallParseAndSum(numbers);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        // Verify object status
        public void SimpleParser_IsParserAndSumCalled_Should_Be_True()
        {
            CallParseAndSum("0");

            Assert.IsTrue(_parser.IsParseAndSumCalled);
        }
        private int CallParseAndSum(string numbers)
        {
            return _parser.ParseAndSum(numbers);
        }
    }

    public class FakeSimpleParser : SimpleParser
    {
        protected override void LogToDb(string numbers, int result)
        {
            
        }
    }
}