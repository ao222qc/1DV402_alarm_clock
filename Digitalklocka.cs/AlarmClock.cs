using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digitalklocka.cs
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        public int AlarmHour
        {
            get
            { return _alarmHour; }

            set {
                if (value < 0 || value > 23)
                { throw new ArgumentException(); }
                
                _alarmHour = value;
                }
        }

        public int AlarmMinute
        {
            get
            { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                { throw new ArgumentException(); }

                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }

            set
            {
                if (value > 23 || value < 0)
                {
                    throw new ArgumentException(); 
                }

               _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                   throw new ArgumentException();
                }

                _minute = value;
            }
        }

        public AlarmClock() 
            :this(0, 0)
        {    
            //Tolkar som att konstr. anropar konstr. med 2 argument, hour 0 å minute 0.
        }

        public AlarmClock(int hour, int minute)
            :this(hour, minute, hour, minute)
        {
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
            
        {
            hour = Hour;
            minute = Minute;
            alarmHour = AlarmHour;
            alarmMinute = AlarmMinute;
        }
        public bool TickTock()
        {
            _minute++;

            if (_minute > 59)
            {
                _minute = 0;
                _hour++;
            }
            if (_hour > 23)
            {
                _hour = 0;
                _minute++;
            }

            if (_hour == _alarmHour && _minute == _alarmMinute)
            {                
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ToString()
        {
            StringBuilder plupp = new StringBuilder();

            plupp.AppendFormat("{0}:", _hour);
            if (_minute < 10)
            {
                plupp.AppendFormat("0{0}-----", _minute);
            }
            else
            {
                plupp.AppendFormat("{0}-----", _minute);
            }
            plupp.AppendFormat("<{0}:", _alarmHour);

            if (_alarmMinute < 10)
            {
                plupp.AppendFormat("0{0}>", _alarmMinute);
            }
            else
            {
                plupp.AppendFormat("{0}>", _alarmMinute);
            }

            
            return plupp.ToString();

        }
    }
}
