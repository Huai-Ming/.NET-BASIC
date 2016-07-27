using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFeatures.Extension
{
    class Extension
    {
        private static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine(date.GetNearFirstDate().FormattedDateString());
            Console.Read();
        }
    }

    public static class TypeExtension
    {
        public static DateTime GetNearFirstDate(this DateTime date)
        {
            if (date.Day == 1)
            {
                return date;
            }

            DateTime nextDate = date.AddMonths(1);

            return new DateTime(nextDate.Year, nextDate.Month, 1);
        }

        public static string FormattedDateString(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }
    }
}
