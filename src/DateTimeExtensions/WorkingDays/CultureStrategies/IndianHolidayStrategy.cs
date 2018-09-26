﻿using System.Globalization;
using DateTimeExtensions.Common;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("en-IN")]
    public class IndianHolidayStrategy : HolidayStrategyBase
    {
        private static readonly Calendar IndianCalendar = new GregorianCalendar(GregorianCalendarTypes.Localized);

        public IndianHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);
            InnerHolidays.Add(GlobalHolidays.MayDay);
            InnerHolidays.Add(IndependenceDay);
            InnerHolidays.Add(RepublicDay);
            InnerHolidays.Add(GandhiBirthAnniversary);

        }
        private static Holiday independenceDay;
        public static Holiday IndependenceDay
        {
            get
            {
                if (independenceDay == null)
                {
                    independenceDay = new FixedHoliday("Independence Day", 8, 15, IndianCalendar);
                }
                return independenceDay;
            }
        }


        private static Holiday republicDay;
        public static Holiday RepublicDay
        {
            get
            {
                if (republicDay == null)
                {
                    republicDay = new FixedHoliday("Republic Day", 1, 26, IndianCalendar);
                }
                return republicDay;
            }
        }


        private static Holiday gandhiBirthAnniversary;
        public static Holiday GandhiBirthAnniversary
        {
            get
            {
                if (gandhiBirthAnniversary == null)
                {
                    gandhiBirthAnniversary = new FixedHoliday("Gandhi's Birth Anniversary", 10, 2, IndianCalendar);
                }
                return gandhiBirthAnniversary;
            }
        }
    }
}