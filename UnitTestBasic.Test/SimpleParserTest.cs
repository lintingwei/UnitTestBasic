using NUnit.Framework;

namespace UnitTestBasic.Test
{
    public class SimpleParserTest
    {
        private FakeSimpleParser _parser;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            _parser = new FakeSimpleParser(new Logger());
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

        [Test]
        // verify object interact with other object
        public void SimpleParser_IsLogToDbCalled_Should_Be_True()
        {
            CallParseAndSum("1,2");

            Assert.IsTrue(_parser.IsLogToDbCalled);
        }

        [Test]
        // verify object interact with other object
        public void SimpleParser_IsLogToDbCalled_Should_Be_False()
        {
            CallParseAndSum("1");

            Assert.IsFalse(_parser.IsLogToDbCalled);
        }

        private int CallParseAndSum(string numbers)
        {
            return _parser.ParseAndSum(numbers);
        }
    }

    public class FakeSimpleParser : SimpleParser
    {
        public FakeSimpleParser(ILogger logger):base(logger)
        {
        }
        public bool IsLogToDbCalled { get; set; }
        protected override void LogToDb(string numbers, int result)
        {
            IsLogToDbCalled = true;
        }
    }
}