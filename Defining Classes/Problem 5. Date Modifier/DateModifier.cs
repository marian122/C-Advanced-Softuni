﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DefiningClasses
{
   public class DateModifier
    {
        public static double GetDifferenceBetweenTwoDates(string dateOne, string dateTwo)
        {
            var firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (firstDate > secondDate)
            {
                return GetDifferenceBetweenTwoDates(dateTwo, dateOne);
            }
            return (secondDate - firstDate).Days;
        }
    }
}
