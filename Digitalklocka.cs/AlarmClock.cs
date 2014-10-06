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
            { return _alarmHour; } //När värdet är godkänt utav if-satsen tilldelas fältet värdet.

            set {
                if (value < 0 || value > 23)
                { throw new ArgumentException("Alarm Hour is not in the interval 0-23."); } //Kastar undantag Arg.Exc och skickar med ett argument till den klassen. Lagras i metoden "Message" vad jag förstår.
                
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
                { throw new ArgumentException("Alarm Minute is not in the interval 0-59."); }//Kastar undantag Arg.Exc och skickar med ett argument till den klassen. Lagras i metoden "Message" vad jag förstår.

                _alarmMinute = value;
            }
        }//egenskap som kontrollerar värden innan de tilldelas till fält

        public int Hour
        {
            get { return _hour; }


      
            set
            {
                 if (value < 0 || value > 23)
                    {
                        throw new ArgumentException("Hour is not in the interval 0-23."); //Kastar undantag Arg.Exc och skickar med ett argument till den klassen. Lagras i metoden "Message" vad jag förstår.
                    }
               _hour = value;
            }
        } //egenskap som kontrollerar värden innan de tilldelas till fält
     
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {

                    throw new ArgumentException("Minute is not in the interval 0-59.");//Kastar undantag Arg.Exc och skickar med ett argument till den klassen. Lagras i metoden "Message" vad jag förstår.
                }

                _minute = value;
            }
        }//egenskap som kontrollerar värden innan de tilldelas till fält

        public AlarmClock()  //Anropar konstruktorn som har 2 parameterfält med två argument som är 0 och 0, för att "återställa datan".
            :this(0, 0)
        {    
           
        }

        public AlarmClock(int hour, int minute)//Anropar konstruktor med 4 parameterfält, skickar med hour och minute + återställer alarmdatan till 0.
            :this(hour, minute, 0, 0)
        {
            
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute) // skickar med datan till egenskaperna som i sin tur skickar in datan till fälten
            
        {             
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
           
        }

        public bool TickTock()//Metod som "simulerar" att klockan går, har även hand om att kontrollera om tiden når den satta alarmtiden.
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
        public string ToString() //lagrar sträng och fält i en string, ifsatser bestämmer vad som visas så formaten ser bättre ut i konsolfönstret.
        {
            StringBuilder display = new StringBuilder();

           
                display.AppendFormat("{0,5}:", _hour);
            
            if (_minute < 10) //Slänger in en extra nolla när minuten är "entalig".
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
