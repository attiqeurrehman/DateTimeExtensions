using System;
using System.Collections.Generic;
using DateTimeExtensions.Common;

namespace DateTimeExtensions.NaturalText.CultureStrategies
{
    [Locale("pl-PL")]
    public class PL_PLNaturalTimeStrategy : NaturalTimeStrategyBase
    {
        protected override string YearText => "rok";

        protected override string MonthText => "miesiąc";

        protected override string DayText => "dzień";

        protected override string HourText => "godzina";

        protected override string MinuteText => "minuta";

        protected override string SecondText => "sekunda";

        protected override string Pluralize(string text, int value)
        {
            List<int> lastDigitsWithDifferentDeclination = new List<int> { 2, 3, 4 };
            List<int> exceptions = new List<int> { 12, 13, 14 };

            bool hasDifferentDeclination = lastDigitsWithDifferentDeclination.Contains(value % 10) && !exceptions.Contains(value % 100);

            if (text.Equals("rok", StringComparison.OrdinalIgnoreCase))
            {
                if(hasDifferentDeclination)
                {
                    return "lata";
                }
                return "lat";
            }
            if (text.Equals("miesiąc", StringComparison.OrdinalIgnoreCase))
            {
                if (hasDifferentDeclination)
                {
                    return "miesiące";
                }
                return "miesięcy";
            }
            if (text.Equals("dzień", StringComparison.OrdinalIgnoreCase))
            {
                return "dni";
            }
            
            if(text.EndsWith("a"))
            {
                if(hasDifferentDeclination)
                {
                    return text.Remove(text.Length - 1) + "y";
                }
                return text.Remove(text.Length - 1);
            }
            return base.Pluralize(text, value);
        }
    }
}
