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

        [Test]
        // Verify return value
        public void SimpleParser_Should_Return_0()
        {
            // Act
            var result = CallParseAndSum();

            // Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        // Verify object status
        public void SimpleParser_IsParserAndSumCalled_Should_Be_True()
        {
            CallParseAndSum();

            Assert.IsTrue(_parser.IsParseAndSumCalled);
        }
        private int CallParseAndSum()
        {
            return _parser.ParseAndSum("0");
        }
    }
}