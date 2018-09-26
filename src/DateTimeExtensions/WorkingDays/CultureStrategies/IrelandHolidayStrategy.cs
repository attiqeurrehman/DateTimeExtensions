using System;
using DateTimeExtensions.Common;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("en-IE")]
    public class IrelandHolidayStrategy : HolidayStrategyBase
    {
        public IrelandHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);
            InnerHolidays.Add(GlobalHolidays.StPatricsDay);
            InnerHolidays.Add(ChristianHolidays.EasterMonday);
            InnerHolidays.Add(new NthDayOfWeekAfterDayHoliday("May Day", 1, DayOfWeek.Monday, GlobalHolidays.MayDay));
            InnerHolidays.Add(JuneHoliday);
            InnerHolidays.Add(AugustHoliday);
            InnerHolidays.Add(OctoberHoliday);
            InnerHolidays.Add(ChristianHolidays.Christmas);
            InnerHolidays.Add(ChristianHolidays.StStephansDay);
        }

        // 1st Monday in June - June Holiday
        private static Holiday juneHoliday;

        public static Holiday JuneHoliday => juneHoliday ??
                                             (juneHoliday =
                                                 new NthDayOfWeekInMonthHoliday("June Holiday", 1, DayOfWeek.Monday, 6,
                                                     CountDirection.FromFirst));

        // 1st Monday in August - August Holiday
        private static Holiday augustHoliday;

        public static Holiday AugustHoliday => augustHoliday ??
                                               (augustHoliday =
                                                   new NthDayOfWeekInMonthHoliday("August Holiday", 1, DayOfWeek.Monday, 8,
                                                       CountDirection.FromFirst));

        // lasy Monday in October - October Holiday
        private static Holiday octoberHoliday;

        public static Holiday OctoberHoliday => octoberHoliday ??
                                                (octoberHoliday =
                                                    new NthDayOfWeekInMonthHoliday("October Holiday", 1, DayOfWeek.Monday, 10,
                                                        CountDirection.FromLast));
    }
}