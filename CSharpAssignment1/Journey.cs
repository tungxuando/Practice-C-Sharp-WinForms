using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class Journey
    {
        private Taxi taxi;
        private DateTime startTime;
        private DateTime endTime;
        private DayOfWeek dayOfWeek;
        private decimal distance;
        public Journey(Taxi taxi, DateTime startTime, DateTime endTime, DayOfWeek dayOfWeek, decimal distance)
        {
            this.Taxi = taxi;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.DayOfWeek = dayOfWeek;
            this.Distance = distance;
        }

        public DateTime StartTime
        {
            get
            {
                return this.startTime;
            }
            set
            {
                if (isPastTime(value))
                {
                    throw new Exception("Start time cannot be in the past");
                }
                this.startTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return this.endTime;
            }
            set
            {
                if (isPastTime(value))
                {
                    throw new Exception("End time cannot be in the past");
                }

                else if(value.Hour < this.startTime.Hour)
                {
                    throw new Exception("End time must be in the future compare to start time");
                }
                this.endTime = value;
            }
        }
        public DayOfWeek DayOfWeek
        {
            get
            {
                return this.dayOfWeek;
            }
            set
            {
                this.dayOfWeek = value;
            }
        }
        public decimal Distance
        {
            get
            {
                return this.distance;
            }
            set
            {
                if (!isValidDistance(value))
                {
                    throw new Exception("Distance must be greater than 0");
                }
                this.distance = value;
            }
        }

        public Taxi Taxi
        {
            get
            {
                return this.taxi;
            }
            set
            {
                this.taxi = value;
            }
        }

        private bool isPastTime(DateTime date)
        {
            if (date.Hour < DateTime.Now.Hour)
            {
                return true;
            }

            return false;
        }
        private bool isValidDistance(decimal number)
        {
            if (number <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
