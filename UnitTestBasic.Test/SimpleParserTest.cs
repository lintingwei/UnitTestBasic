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
    }
}