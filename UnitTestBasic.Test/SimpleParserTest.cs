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
            _parser = new SimpleParser();
        }

        [TestCase("0", TestName = "Should return 0")]
        [TestCase("1,2", TestName = "Should return 3")]
        // Verify return value
        public void SimpleParser_Should_Return_0(string numbers)
        {
            // Act
            var result = CallParseAndSum(numbers);

            // Assert
            Assert.AreEqual(0, result);
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
}