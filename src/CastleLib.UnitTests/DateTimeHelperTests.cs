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

        [TestMethod]
        public void GetDatesTest_起始時間大於結束時間_回傳空集合()
        {
            // arrange
            var now = DateTime.Now;
            var startDate = now;
            var endDate = now.AddMilliseconds(-1);
            var dayOfWeek = DayOfWeek.Sunday;
            var expected = Enumerable.Empty<DateTime>();

            // act
            var actual = DateTimeHelper.GetDates(startDate, endDate, dayOfWeek);

            // assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void GetDatesTest_20240215至20240220的禮拜三_回傳空集合()
        {
            // arrange
            var startDate = new DateTime(2024, 2, 15);
            var endDate = new DateTime(2024, 2, 20);
            var dayOfWeek = DayOfWeek.Wednesday;
            var expected = Enumerable.Empty<DateTime>();

            // act
            var actual = DateTimeHelper.GetDates(startDate, endDate, dayOfWeek);

            // assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void GetDatesTest_20240214至20240301的禮拜四_回傳三項()
        {
            // arrange
            var startDate = new DateTime(2024, 2, 14);
            var endDate = new DateTime(2024, 3, 1);
            var dayOfWeek = DayOfWeek.Thursday;
            var expected = new List<DateTime>()
            {
                new(2024, 2, 15),
                new(2024, 2, 22),
                new(2024, 2, 29)
            };

            // act
            var actual = DateTimeHelper.GetDates(startDate, endDate, dayOfWeek);

            // assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
