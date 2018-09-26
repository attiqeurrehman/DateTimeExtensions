#region License

// 
// Copyright (c) 2011-2012, João Matos Silva <kappy@acydburne.com.pt>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

#endregion

using System;
using DateTimeExtensions.Common;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("fi-FI")]
    public class FI_FIHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
    {
        public FI_FIHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);
            InnerHolidays.Add(ChristianHolidays.Epiphany);
            InnerHolidays.Add(ChristianHolidays.GoodFriday);
            InnerHolidays.Add(ChristianHolidays.Easter);
            InnerHolidays.Add(ChristianHolidays.EasterMonday);
            InnerHolidays.Add(GlobalHolidays.MayDay);
            InnerHolidays.Add(ChristianHolidays.Ascension);
            InnerHolidays.Add(ChristianHolidays.Pentecost);
            InnerHolidays.Add(GlobalHolidays.MidsummerEve);
            InnerHolidays.Add(GlobalHolidays.MidsummerDay);
            InnerHolidays.Add(AllSaintsDay);
            InnerHolidays.Add(IndependanceDay);
            InnerHolidays.Add(ChristianHolidays.ChristmasEve);
            InnerHolidays.Add(ChristianHolidays.Christmas);
            InnerHolidays.Add(ChristianHolidays.StStephansDay);
        }

        private static Holiday independanceDay;

        public static Holiday IndependanceDay
        {
            get
            {
                if (independanceDay == null)
                {
                    independanceDay = new FixedHoliday("Independance Day", 12, 6);
                }
                return independanceDay;
            }
        }

        //All Saints' Day - Saturday between 31 October and 6 November
        // - Same as ChristianHolidays.AllSaints but has diferent ocurrence
        private static Holiday allSaintsDay;

        public static Holiday AllSaintsDay
        {
            get
            {
                if (allSaintsDay == null)
                {
                    allSaintsDay = new NthDayOfWeekAfterDayHoliday("All Saint's Day", 1, DayOfWeek.Saturday, 10, 31);
                }
                return allSaintsDay;
            }
        }
    }
}