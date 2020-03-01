using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfullWebSvc.Helpers
{
    public static class DateTimeOffsetExtension
    {
        public static int GetCurrentAge (this DateTimeOffset dateTimeOffset)
        {
            var currentDate = DateTime.UtcNow;
            int age = currentDate.Year - dateTimeOffset.Year;

            return currentDate < dateTimeOffset.AddYears(age) ? --age : age;
        }
    }
}
