using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzz.Interfaces
{
    public class DayoftheWeek
    {
        public bool VerifyDayoftheWeek(string dayoftheWeek)
        {
            return DateTime.Today.DayOfWeek.ToString() == dayoftheWeek;
        }
    }
}