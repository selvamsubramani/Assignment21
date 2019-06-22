using System;

namespace FSE.Assignment21.Task01
{
    public class SelfHostingService : ISelfHostingService
    {
        public string SayHello(string name)
        {
            var currentTime = DateTime.Now;
            if (currentTime.Hour <= 11)
                return $"Good Morning {name} \t Time: {currentTime}";
            if (currentTime.Hour >= 12 && currentTime.Hour <= 15)
                return $"Good Afternoon {name} \t Time: {currentTime}";
            if (currentTime.Hour > 15)
                return $"Good Evening {name} \t Time: {currentTime}";
            return name;
        }
        public string TodayProgram(string name)
        {
            var currentDay = DateTime.Today.DayOfWeek;
            if (currentDay == DayOfWeek.Saturday || currentDay == DayOfWeek.Sunday)
                return $"Happy Weekend {name}";
            else
                return $"Enjoy Working day {name}";
        }
    }
}