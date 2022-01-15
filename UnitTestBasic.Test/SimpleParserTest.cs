using NUnit.Framework;

namespace UnitTestBasic.Test
{
    public class SimpleParserTest
    {
        [Test]
        public void SimpleParser_Should_Return_0()
        {
            // Arrange
            var parser = new SimpleParser();

            // Act
            var result = parser.ParseAndSum("0");

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void SimpleParser_IsParserAndSumCalled_Should_Be_True()
        {
            var parser = new SimpleParser();

            parser.ParseAndSum(string.Empty);

            Assert.IsTrue(parser.IsParseAndSumCalled);
        }
    }
}