using System;

namespace Section7DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            // 59. DATETIME
            // ============


            var dateTime = new DateTime(1990, 4, 4);

            var now = DateTime.Now;
            var today = DateTime.Today;

            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;

            // DateTime objects are immutable.
            // To make changes, you need to use these methods.

            var tomorrow = now.AddDays(1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));




            // 60. TIMESPAN
            // ============

            // This structure represents a certain duration of time.

            // Hours, minutes, seconds
            var timeSpan = new TimeSpan(1, 2, 3);

            // These to lines are the same thing:
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);


            // An example of a timespan using DateTime.

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: " + duration);


            // TimeSpan properties

            // Calculating total minutes.
            var totalMinutes = timeSpan.TotalMinutes;
            Console.WriteLine("Total Minutes " + totalMinutes);


            // Timespan is also immutable. You need to use the timespan methods to make changes.

            var addingMinutes = timeSpan.Add(TimeSpan.FromMinutes(8));
            Console.WriteLine("Adding Minutes " + addingMinutes);

            var subtractMinutes = timeSpan.Subtract(TimeSpan.FromMinutes(8));
            Console.WriteLine("Subtract Minutes " + subtractMinutes);
        }
    }
}
