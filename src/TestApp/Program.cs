using System;
using System.Linq;
using TimeZoneConverter;

namespace TestApp
{
    class Program
    {
        static void Main()
        {
            var timeZoneInfo = TZConvert.GetTimeZoneInfo("Europe/Moscow");
            Console.WriteLine(timeZoneInfo);
            Console.WriteLine($"BaseUtcOffset: {timeZoneInfo.BaseUtcOffset}");
            Console.WriteLine($"DTS offset: {timeZoneInfo.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta.ToString() ?? "N/A"}");
            Console.WriteLine($"Winter time: {TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2021, 1, 1), timeZoneInfo)}");
            Console.WriteLine($"Summer time: {TimeZoneInfo.ConvertTimeFromUtc(new DateTime(2021, 7, 1), timeZoneInfo)}");
        }
    }
}