using DateTimeExtensions.Common;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("en-GD")]
    [Locale("gd-GD")]
    public class ScotlandHolidayStrategy : HolidayStrategyBase
    {
        public ScotlandHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);
            InnerHolidays.Add(NewYearHoliday);
            InnerHolidays.Add(ChristianHolidays.GoodFriday);
            InnerHolidays.Add(EN_GBHolidayStrategy.MayDayBank);
            InnerHolidays.Add(EN_GBHolidayStrategy.SpringBank);
            InnerHolidays.Add(EN_GBHolidayStrategy.LateSummerBank);
            InnerHolidays.Add(StAndrewsDay);
            InnerHolidays.Add(ChristianHolidays.Christmas);
            InnerHolidays.Add(EN_GBHolidayStrategy.BoxingDay);
        }

        // 2nd January - New Year Holiday
        private static Holiday newYearHoliday;

        public static Holiday NewYearHoliday => newYearHoliday ?? (newYearHoliday = new FixedHoliday("New Year Holiday", 1, 2));

        // 30 November - St. Andrew's Day
        private static Holiday stAndrewsDay;

        public static Holiday StAndrewsDay => stAndrewsDay ?? (stAndrewsDay = new FixedHoliday("St. Andrew's Day", 11, 30));
    }
}