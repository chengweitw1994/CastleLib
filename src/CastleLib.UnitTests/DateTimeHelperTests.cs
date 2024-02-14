using FluentAssertions;

namespace CastleLib.UnitTests
{
    [TestClass]
    public class DateTimeHelperTests
    {
        [TestMethod]
        public void GetDatesTest_20240214至20240214的禮拜三_回傳20240214()
        {
            // arrange
            var startDate = new DateTime(2024, 2, 14);
            var endDate = new DateTime(2024, 2, 14);
            var dayOfWeek = DayOfWeek.Wednesday;
            var expected = new List<DateTime>()
            {
                new(2024, 2, 14)
            };

            // act
            var actual = DateTimeHelper.GetDates(startDate, endDate, dayOfWeek);

            // assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
