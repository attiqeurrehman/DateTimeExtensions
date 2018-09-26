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

using System.Globalization;

namespace DateTimeExtensions.WorkingDays
{
    public static class JewishHolidays
    {
        private static readonly Calendar HebrewCalendar = new HebrewCalendar();

        private static Holiday roshHashanah;

        public static Holiday RoshHashanah => roshHashanah ??
                                              (roshHashanah = new FixedHoliday("Rosh Hashanah", new DayInYear(1, 1, HebrewCalendar)));

        private static Holiday roshHashanahSecondDay;

        public static Holiday RoshHashanahSecondDay => roshHashanahSecondDay ??
                                                       (roshHashanahSecondDay = new FixedHoliday("Rosh Hashanah", new DayInYear(1, 2, HebrewCalendar)));

        private static Holiday yomKippur;

        public static Holiday YomKippur => yomKippur ?? (yomKippur = new FixedHoliday("Yom Kippur", new DayInYear(1, 10, HebrewCalendar)));

        private static Holiday sukkot;

        public static Holiday Sukkot => sukkot ?? (sukkot = new FixedHoliday("Sukkot", new DayInYear(1, 15, HebrewCalendar)));

        private static Holiday shminiAtzeret;

        public static Holiday ShminiAtzeret => shminiAtzeret ??
                                               (shminiAtzeret = new FixedHoliday("Shmini Atzeret", new DayInYear(1, 22, HebrewCalendar)));

        private static Holiday shminiTorah;

        public static Holiday ShminiTorah => shminiTorah ??
                                             (shminiTorah = new FixedHoliday("Shmini Torah", new DayInYear(1, 23, HebrewCalendar)));

        private static Holiday pesach;

        public static Holiday Pesach => pesach ?? (pesach = new FixedHoliday("Pesach", new DayInYear(7, 15, HebrewCalendar)));

        private static Holiday shviiShelPesach;

        public static Holiday ShviiShelPesach => shviiShelPesach ??
                                                 (shviiShelPesach = new FixedHoliday("Shvi'i shel Pesach", new DayInYear(7, 21, HebrewCalendar)));

        private static Holiday shavuot;

        public static Holiday Shavuot => shavuot ?? (shavuot = new FixedHoliday("Shavuot", new DayInYear(9, 6, HebrewCalendar)));

        private static Holiday tuBishvat;

        public static Holiday TuBishvat => tuBishvat ?? (tuBishvat = new FixedHoliday("Tu Bishvat", new DayInYear(5, 15, HebrewCalendar)));
    }
}