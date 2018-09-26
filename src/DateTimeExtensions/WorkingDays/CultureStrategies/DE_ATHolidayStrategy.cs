using DateTimeExtensions.Common;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("de-AT")]
    public class DE_ATHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
    {
        public DE_ATHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);
            InnerHolidays.Add(ChristianHolidays.Epiphany);
            InnerHolidays.Add(ChristianHolidays.GoodFriday);
            InnerHolidays.Add(ChristianHolidays.EasterMonday);
            InnerHolidays.Add(GlobalHolidays.InternationalWorkersDay);
            InnerHolidays.Add(ChristianHolidays.Ascension);
            InnerHolidays.Add(ChristianHolidays.PentecostMonday);
            InnerHolidays.Add(ChristianHolidays.CorpusChristi);
            InnerHolidays.Add(ChristianHolidays.Assumption);
            InnerHolidays.Add(AustrianNationalHoliday);
            InnerHolidays.Add(ChristianHolidays.AllSaints);
            InnerHolidays.Add(ChristianHolidays.ImaculateConception);
            InnerHolidays.Add(ChristianHolidays.Christmas);
            InnerHolidays.Add(ChristianHolidays.StStephansDay);
            InnerHolidays.Add(GlobalHolidays.NewYearsEve);
        }

        private static Holiday austrianNationalHoliday;

        public static Holiday AustrianNationalHoliday
        {
            get
            {
                if (austrianNationalHoliday == null)
                {
                    austrianNationalHoliday = new FixedHoliday("Austrian National Holiday", 10, 26);
                }
                return austrianNationalHoliday;
            }
        }
    }
}
