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
using System.Reflection;
using System.Resources;

namespace DateTimeExtensions.WorkingDays
{
    /// <summary>
    /// Base representation of an holiday instance
    /// </summary>
    public abstract class Holiday
    {
        /// <summary>
        /// Base Constructor for a new holiday instance
        /// </summary>
        /// <param name="name">name or resource key of the holiday</param>
        protected Holiday(string name)
        {
            Name = name;
        }

        private string _name;

        public string Name
        {
            get => ResourceManager.GetString(_name) ?? _name;
            private set => _name = value;
        }

        public abstract DateTime? GetInstance(int year);
        public abstract bool IsInstanceOf(DateTime date);


        private static ResourceManager resourceManager =
            new ResourceManager("DateTimeExtensions.WorkingDays.HolidayNames", typeof (Holiday).GetTypeInfo().Assembly);

        public static ResourceManager ResourceManager
        {
            get => resourceManager;
            set => resourceManager = value ?? throw new ArgumentNullException("value");
        }
    }
}