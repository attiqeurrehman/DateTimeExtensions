﻿#region License

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

namespace DateTimeExtensions.NaturalText.CultureStrategies
{
    [Locale("ko-KR")]
    public class KO_KRNaturalTimeStrategy : NaturalTimeStrategyBase
    {
        protected override string SentenceJoinerFormat => "{0} {1}";

        protected override string YearText => "년";

        protected override string MonthText => "개월";

        protected override string DayText => "일";

        protected override string HourText => "시간";

        protected override string MinuteText => "분";

        protected override string SecondText => "초";

        protected override string Pluralize(string text, int value)
        {
            return text;
        }
    }
}