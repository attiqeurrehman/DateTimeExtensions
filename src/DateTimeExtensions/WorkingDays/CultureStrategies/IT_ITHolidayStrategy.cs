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
    [Locale("it-IT")]
    public class IT_ITHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
    {
        public IT_ITHolidayStrategy()
        {
            InnerHolidays.Add(GlobalHolidays.NewYear);
            InnerHolidays.Add(ChristianHolidays.Epiphany);
            InnerHolidays.Add(ChristianHolidays.EasterMonday);
            InnerHolidays.Add(GlobalHolidays.InternationalWorkersDay);
            InnerHolidays.Add(RepublicDay);
            InnerHolidays.Add(ChristianHolidays.Assumption);
            InnerHolidays.Add(ChristianHolidays.AllSaints);
            InnerHolidays.Add(ChristianHolidays.ImaculateConception);
            InnerHolidays.Add(ChristianHolidays.Christmas);
            InnerHolidays.Add(ChristianHolidays.StStephansDay);
        }

        //2 June - Republic Day
        private static Holiday republicDay;

        public static Holiday RepublicDay
        {
            get
            {
                if (republicDay == null)
                {
                    republicDay = new FixedHoliday("Republic Day", 6, 2);
                }
                return republicDay;
            }
        }
    }
}