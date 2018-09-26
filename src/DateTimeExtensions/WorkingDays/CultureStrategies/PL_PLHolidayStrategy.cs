using DateTimeExtensions.Common;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("pl-PL")]
    public class PL_PLHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
    {
        public PL_PLHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);

            InnerHolidays.Add(ChristianHolidays.Epiphany);
            InnerHolidays.Add(ChristianHolidays.Easter);
            InnerHolidays.Add(ChristianHolidays.EasterMonday);

            InnerHolidays.Add(GlobalHolidays.InternationalWorkersDay);

            InnerHolidays.Add(May3rdConstitutionDay);

            InnerHolidays.Add(ChristianHolidays.Pentecost);
            InnerHolidays.Add(ChristianHolidays.CorpusChristi);
            InnerHolidays.Add(ChristianHolidays.Assumption);
            InnerHolidays.Add(ChristianHolidays.AllSaints);

            InnerHolidays.Add(NationalIndependenceDay);

            InnerHolidays.Add(ChristianHolidays.Christmas);
            InnerHolidays.Add(ChristianHolidays.StStephansDay);
        }

        private static Holiday may3rdConstitutionDay;

        public static Holiday May3rdConstitutionDay
        {
            get
            {
                if (may3rdConstitutionDay == null)
                {
                    may3rdConstitutionDay = new FixedHoliday("May 3rd Constitution Day", 3, 5);
                }
                return may3rdConstitutionDay;
            }
        }

        private static Holiday nationalIndependenceDay;

        public static Holiday NationalIndependenceDay
        {
            get
            {
                if (nationalIndependenceDay == null)
                {
                    nationalIndependenceDay = new FixedHoliday("National Independence Day", 11, 11);
                }
                return nationalIndependenceDay;
            }
        }
    }
}