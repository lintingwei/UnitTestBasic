using NSubstitute;
using NUnit.Framework;

namespace UnitTestBasic.Test
{
    public class SimpleParserTest
    {
        private SimpleParser _parser;
        private ILogger _logger;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            _logger = Substitute.For<ILogger>();
            _parser = new SimpleParser(_logger);
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
        public void SimpleParser_Should_Call_LogToDb()
        {
            CallParseAndSum("1,2");

            _logger.Received().LogToDb(Arg.Any<string>());
        }

        [Test]
        // verify object interact with other object
        public void SimpleParser_IsLogToDbCalled_Should_Be_False()
        {
            CallParseAndSum("1");

            _logger.DidNotReceive().LogToDb(Arg.Any<string>());
        }

        private int CallParseAndSum(string numbers)
        {
            return _parser.ParseAndSum(numbers);
        }
    }

    //public class FakeSimpleParser : SimpleParser
    //{
    //    public FakeSimpleParser(ILogger logger):base(logger)
    //    {
    //    }
    //    public bool IsLogToDbCalled { get; set; }
    //    protected override void LogToDb(string numbers, int result)
    //    {
    //        IsLogToDbCalled = true;
    //    }
    //}
}