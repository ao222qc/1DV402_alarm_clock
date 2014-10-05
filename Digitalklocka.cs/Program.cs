using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digitalklocka.cs
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string headerLine = "\n===========================================================\n";

            AlarmClock test1 = new AlarmClock();

            ViewTestHeader(headerLine);
            ViewTestHeader("Test 1");
            ViewTestHeader("Test of standard constructor.");
            Console.WriteLine(test1.ToString()); //anropar ToString som skriver ut det som genereras när objektet initieras.
            
            AlarmClock test2 = new AlarmClock(9, 42);
            ViewTestHeader(headerLine);
            ViewTestHeader("Test 2.");
            ViewTestHeader("Check constructor with two parameters.");
            Console.WriteLine(test2.ToString());
            
            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader(headerLine);
            ViewTestHeader("Test 3");
            ViewTestHeader("Test of constructor with four parameters.");
            Console.WriteLine(test3.ToString());
            
            AlarmClock test4 = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader(headerLine);
            ViewTestHeader("Test 4.");
            ViewTestHeader("Test of TickTock Method.");         
            Run(test4, 13); //skickar med argument in i metoden, som håller fast det som objektet initierats med samt "antal minuter" det ska köras.
            
            AlarmClock test5 = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader(headerLine);
            ViewTestHeader("Test 5.");
            ViewTestHeader("Test of TickTock and Alarm.");
            Run(test5, 6); //samma som i test 4.

            ViewTestHeader(headerLine);
            ViewTestHeader("Test 6.");
            ViewTestHeader("Check that properties all throw exceptions when they should.");
            AlarmClock WrongTime = new AlarmClock();   
            try
            {WrongTime.Hour = 24;}
            catch (ArgumentException a)
            {ViewErrorMessage(a.Message);}
            try
            { WrongTime.Minute = 61; }
            catch (ArgumentException a)
            { ViewErrorMessage(a.Message); }
            try
            { WrongTime.AlarmHour = 24; }
            catch (ArgumentException a)
            {ViewErrorMessage(a.Message);}
            try
            { WrongTime.AlarmMinute = 61; }
            catch (ArgumentException a)
            { ViewErrorMessage(a.Message); }

            ViewTestHeader(headerLine);
            ViewTestHeader("Test 7.");
            ViewTestHeader("Check that constructors can't be given invalid values.");
            try
            { AlarmClock WrongTimeConstructor = new AlarmClock(24, 0); }
            catch (ArgumentException a)
            { ViewErrorMessage(a.Message); }
            try
            { AlarmClock WrongTimeConstructor = new AlarmClock(0, 61); }
            catch (ArgumentException a)
            { ViewErrorMessage(a.Message); }          
        }

       private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0} BEEP BEEP BEEP! If you snooze you lose!", ac.ToString());
                    Console.ResetColor();
                }

                else 
                {
                    Console.WriteLine(ac.ToString());
                }
                
            }


        }

       private static void ViewErrorMessage(string message)
       {
           Console.BackgroundColor = ConsoleColor.DarkRed;
           Console.WriteLine(message);
           Console.ResetColor();
       }

       private static void ViewTestHeader(string header)
       {
           Console.WriteLine(header);
       }
    }
    
    
    
     
}
