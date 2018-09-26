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

using DateTimeExtensions.Common;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("sv-SE")]
    public class SV_SEHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
    {
        public SV_SEHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);
            InnerHolidays.Add(ChristianHolidays.Epiphany);
            InnerHolidays.Add(ChristianHolidays.GoodFriday);
            InnerHolidays.Add(ChristianHolidays.Easter);
            InnerHolidays.Add(ChristianHolidays.EasterMonday);
            InnerHolidays.Add(GlobalHolidays.InternationalWorkersDay);
            InnerHolidays.Add(ChristianHolidays.Ascension);
            InnerHolidays.Add(ChristianHolidays.Pentecost);
            InnerHolidays.Add(NationalDay);
            InnerHolidays.Add(GlobalHolidays.MidsummerDay);
            InnerHolidays.Add(ChristianHolidays.AllSaints);
            InnerHolidays.Add(ChristianHolidays.Christmas);
            InnerHolidays.Add(GlobalHolidays.BoxingDay);
        }

        private static Holiday nationalDay;

        public static Holiday NationalDay
        {
            get
            {
                if (nationalDay == null)
                {
                    nationalDay = new FixedHoliday("National Day", 6, 6);
                }
                return nationalDay;
            }
        }
    }
}