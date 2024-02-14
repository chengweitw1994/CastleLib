namespace CastleLib
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// 回傳期間內指定的日子
        /// </summary>
        /// <param name="startDate">起</param>
        /// <param name="endDate">迄</param>
        /// <param name="dayOfWeek">指定星期幾</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static IEnumerable<DateTime> GetDates(DateTime startDate, DateTime endDate, DayOfWeek dayOfWeek)
        {
            if (startDate > endDate) return Enumerable.Empty<DateTime>();

            startDate = startDate.Date;
            endDate = endDate.Date;

            var result = new List<DateTime>();
            do
            {
                if (startDate.DayOfWeek == dayOfWeek)
                    result.Add(startDate);

                startDate = startDate.AddDays(1);
            }
            while (startDate <= endDate);

            return result;
        }
    }
}
