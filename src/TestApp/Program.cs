using System;
using System.Linq;
using TimeZoneConverter;

namespace TestApp
{
    class Program
    {
        static void Main()
        {
            var timeZoneInfo = TZConvert.GetTimeZoneInfo("Europe/Belgrade");
            Console.WriteLine(timeZoneInfo);
            Console.WriteLine($"BaseUtcOffset: {timeZoneInfo.BaseUtcOffset}");
            Console.WriteLine($"DTS offset: {timeZoneInfo.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta.ToString() ?? "N/A"}");
        }
    }
}