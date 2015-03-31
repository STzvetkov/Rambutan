namespace Zoo.Schedules
{
    using System;
    using System.Collections.Generic;

    public class Schedule
    {
        // TODO : Add fields and methods which all schedules should have.

        private List<DayOfWeek> toDoAtDay = new List<DayOfWeek>();

        public List<string> time { get; }

        public void AddTime(string newTime)
        {
            this.time.Add(newTime);
        }

        public void RemoveTime(string removedTime)
        {
            this.time.Remove(removedTime);
        }

        public Frequency Repeat
        {
            get
            {
                return this.Repeat;
            }
            set 
            {
                if (value == Frequency.daily)
                {
                    this.toDoAtDay.Clear();
                    this.toDoAtDay.Add(DayOfWeek.Monday);
                    this.toDoAtDay.Add(DayOfWeek.Tuesday);
                    this.toDoAtDay.Add(DayOfWeek.Wednesday);
                    this.toDoAtDay.Add(DayOfWeek.Thursday);
                    this.toDoAtDay.Add(DayOfWeek.Friday);
                    this.toDoAtDay.Add(DayOfWeek.Saturday);
                    this.toDoAtDay.Add(DayOfWeek.Sunday);
                }
                this.Repeat = value;
            }

        }


        public void AddDay(DayOfWeek day)
        {
            if (!RepeatValidate())
            {
                this.toDoAtDay.Add(day);

            }
            else
            {
                throw new ArgumentNullException("Can not add days to this schedule. RepeatAt is set to \"daily\"");
            }
        }

        public void RemoveDay(DayOfWeek day)
        {
            if (!RepeatValidate())
            {
                this.toDoAtDay.Remove(day);
            }
            else
            {
                throw new ArgumentNullException("Can not remove days from this schedule. RepeatAt is set to \"daily\"");
            }
        }

        public Schedule()
        {
            this.Repeat = Frequency.daily;
        }

        public Schedule(string newTime)
        {
            this.time.Add(newTime);
            this.Repeat = Frequency.daily;
        }

        public Schedule(string newTime, Frequency repeat)
        {
            this.time.Add(newTime);
            this.Repeat = repeat;
        }

        public bool RepeatValidate()
        {
            if (this.Repeat == Frequency.daily)
            {
                return true;
            }
            return false;
        }



    }
}
