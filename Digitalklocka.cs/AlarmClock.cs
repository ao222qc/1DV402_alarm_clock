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
        } //egenskap som kontrollerar värden innan de tilldelas till fält

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
        }//egenskap som kontrollerar värden innan de tilldelas till fält

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
        }//egenskap som kontrollerar värden innan de tilldelas till fält

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
        }//egenskap som kontrollerar värden innan de tilldelas till fält

        public AlarmClock() 
            :this(0, 0)
        {    
            //Anropar konstruktorn som har 2 parameterfält med två argument som är 0 och 0, för att "återställa datan".
        }

        public AlarmClock(int hour, int minute)
            :this(hour, minute, 0, 0)
        {
            //Anropar konstruktor med 4 parameterfält, skickar med hour och minute + återställer alarmdatan till 0.
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
            
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            // skickar med datan till egenskaperna som i sin tur skickar in datan till fälten
        }
        public bool TickTock()
        {
            _minute++;

            if (_minute > 59) //Växlar upp en timme när det gått 60 min.
            {
                _minute = 0;
                _hour++;          
            }

            if (_hour > 23) //Nollställer timmar när det gått ett dygn.
            {
                _hour = 0;
            }
      
            if (_hour == _alarmHour && _minute == _alarmMinute) //returnerar true när klockan når alarmtiden.
            {                           
                return true;
            }
           
            else
            {  
                return false;
            }
            
        }
        public string ToString() //lagrar sträng och fält i en string, ifsatser bestämmer vad som visas. 
        {
            StringBuilder display = new StringBuilder();

            if (_hour < 10)
            {
                display.AppendFormat("{0,5}:", _hour);
            }
            else
            {
             display.AppendFormat("{0,5}:", _hour);
            }
            
            if (_minute < 10)
            {
                display.AppendFormat("0{0}", _minute);
            }
            else
            {
                display.AppendFormat("{0}", _minute);
            }

            display.AppendFormat(" <{0,1}:", _alarmHour);

            if (_alarmMinute < 10)
            {
                display.AppendFormat("0{0,1}>", _alarmMinute);
            }
            else
            {
                display.AppendFormat("{0,1}>", _alarmMinute);
            }

            return display.ToString();

        }
    }
}
