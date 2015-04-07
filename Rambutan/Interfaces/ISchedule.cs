using System;

namespace Zoo.Interfaces
{
    interface ISchedule
    {
        void AddTime(string newTime);
        void RemoveTime(string removedTime);
        void AddDay(DayOfWeek day);
    }
}
