using FluentAssertions;

namespace CastleLib.UnitTests
{
    [TestClass]
    public class FluentAssertionsTests
    {
        [TestMethod]
        public void BeEquivalentToTest_比較有相同value但不同instance的兩個集合()
        {
            // arrange
            var expected = new List<DateTime>
            {
                new(2024, 2, 13),
                new(2024, 2, 14)
            };

            // act
            var actual = new List<DateTime>
            {
                new(2024, 2, 14),
                new(2024, 2, 13)
            };

            // assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
