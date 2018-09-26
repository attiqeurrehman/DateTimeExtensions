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
    [Locale("nb-NO")]
    public class NB_NOHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
    {
        public NB_NOHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);
            InnerHolidays.Add(ChristianHolidays.MaundyThursday);
            InnerHolidays.Add(ChristianHolidays.GoodFriday);
            InnerHolidays.Add(ChristianHolidays.Easter);
            InnerHolidays.Add(ChristianHolidays.EasterMonday);
            InnerHolidays.Add(GlobalHolidays.InternationalWorkersDay);
            InnerHolidays.Add(ConstitutionDay);
            InnerHolidays.Add(ChristianHolidays.Ascension);
            InnerHolidays.Add(ChristianHolidays.Pentecost);
            InnerHolidays.Add(ChristianHolidays.PentecostMonday);
            InnerHolidays.Add(ChristianHolidays.Christmas);
            InnerHolidays.Add(ChristianHolidays.StStephansDay);
        }

        private static Holiday constituionDay;

        public static Holiday ConstitutionDay
        {
            get
            {
                if (constituionDay == null)
                {
                    constituionDay = new FixedHoliday("Constitution Day", 5, 17);
                }
                return constituionDay;
            }
        }
    }
}