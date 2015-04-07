namespace Zoo.Schedules
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Zoo.Interfaces;
    using Zoo.Schedules;

    public class Schedule : ISchedule
    {
        // TODO : Override ToString()

        // TODO : Add fields and methods which all schedules should have.

        private string name;

        private string repeat;

        private ICollection<DayOfWeek> weekDays;

        private ICollection<string> time;


        public Schedule(string newName, string newTime)
        {
            this.time = new List<string>();
            this.weekDays = new List<DayOfWeek>();
            this.Name = newName;
            this.Repeat = FrequencyType.Daily.ToString();
            this.time.Add(newTime);
        }

        public Schedule(string newName, string newTime, string newRepeat)
        {
            this.time = new List<string>();
            this.weekDays = new List<DayOfWeek>();
            this.Name = newName;
            this.Repeat = newRepeat;
            this.time.Add(newTime);
        }

        public virtual void AddTime(string newTime)
        {
            this.time.Add(newTime);
        }

        public virtual void RemoveTime(string removedTime)
        {
            this.time.Remove(removedTime);
        }

        public virtual string Repeat
        {
            get
            {
                return this.repeat;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Repeat cannot be null or empty");
                }
                if (!RepeatValidate(value))
                {
                    throw new ArgumentException("The input is not valid! Pleace enter Daily, Weekly or Once!");
                }
                if (value == FrequencyType.Daily.ToString())
                {
                    this.weekDays.Clear();
                    this.weekDays.Add(DayOfWeek.Monday);
                    this.weekDays.Add(DayOfWeek.Tuesday);
                    this.weekDays.Add(DayOfWeek.Wednesday);
                    this.weekDays.Add(DayOfWeek.Thursday);
                    this.weekDays.Add(DayOfWeek.Friday);
                    this.weekDays.Add(DayOfWeek.Saturday);
                    this.weekDays.Add(DayOfWeek.Sunday);
                }
                this.repeat = value;
            }

        }


        public void AddDay(DayOfWeek day)
        {
            if (repeat == FrequencyType.Once.ToString())
            {
                throw new ArgumentException("Repeat is set to \"once\"! Cannot add days!");
            }
            else if (repeat == FrequencyType.Weekly.ToString())
            {
                this.weekDays.Add(day);
            }
            else
            {
                throw new ArgumentNullException("Can not add days to this schedule. Repeat is set to \"daily\"");
            }
        }

        public void RemoveDay(DayOfWeek day)
        {
            if (repeat == FrequencyType.Once.ToString())
            {
                throw new ArgumentException("Repeat is set to \"once\"! Cannot remove days!");
            }
            else if (repeat == FrequencyType.Weekly.ToString())
            {
                this.weekDays.Remove(day);
            }
            else
            {
                throw new ArgumentNullException("Can not remove days from this schedule. Repeat is set to \"daily\"");
            }
        }

        public bool RepeatValidate(string repeat)
        {
            foreach (FrequencyType day in Enum.GetValues(typeof(FrequencyType)))
            {
                if (repeat==day.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder schedule = new StringBuilder();
            schedule.AppendLine(string.Format("{0} - {1} : {2}", this.GetType().Name, this.Name, this.Repeat));
            schedule.Append("Days: ");
            schedule.AppendLine(string.Join(", ", this.weekDays));
            schedule.Append("Time: ");
            schedule.AppendLine(string.Join(" / ", this.time));

            return schedule.ToString();
        }
    }
}
