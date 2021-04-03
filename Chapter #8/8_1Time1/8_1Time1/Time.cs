using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1Time1
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
            SetTime(0, 0, 0);
        }

        public Time(int hourValue, int minuteValue, int secondValue)
        {
            SetTime(hourValue, minuteValue, secondValue);
        }

        public void SetTime(int hourValue, int minuteValue, int secondValue)
        {
            if (hour > 24)
            {
                throw new ArgumentException("Invalid Hour");
            }

            if (minute > 60)
            {
                throw new ArgumentException("Invalid Minute");
            }

            if (second > 60)
            {
                throw new ArgumentException("Invalid Second");
            }

            hour = hourValue;
            minute = minuteValue;
            second = secondValue; 
        }

        public string ToUniversalString()
        {
            return String.Format(
                "{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        }

        public override string ToString()
        {
            string period = hour < 12 ? "AM" : "PM";
            return String.Format("{0} {1}", ToUniversalString(), period);
        }
    }
}
