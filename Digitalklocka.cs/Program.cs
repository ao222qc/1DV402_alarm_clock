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
            string HorizontalLine = "\n===========================================================\n";

            AlarmClock test1 = new AlarmClock();
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("Test 1.\nTest of standard constructor.");
            ViewTestHeader(test1.ToString()); //anropar ToString som skriver ut det som genereras när objektet initieras.
            
            AlarmClock test2 = new AlarmClock(9, 42);
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("Test 2.\nCheck constructor with two parameters. ");
            ViewTestHeader(test2.ToString());
            
            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("Test 3.\n Test of constructor with four parameters.");
            ViewTestHeader(test3.ToString());
            
            AlarmClock test4 = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("Test 4.\nTest of TickTock Method.");       
            Run(test4, 13); //skickar med argument in i metoden, som håller fast det som objektet initierats med samt "antal minuter" det ska köras.
            
            AlarmClock test5 = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("Test 5.\nTest of TickTock and Alarm.");
            Run(test5, 6); //samma som i test 4.

            ViewTestHeader(HorizontalLine);
            ViewTestHeader("Test 6.\nCheck that properties all throw exceptions when they should.");
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

            //Här tilldelar jag egenskaperna felaktiga värden en åt gången, inom try-catch.
            //Lämpligt felmeddelande visas när undantaget kastas och fångas.

            ViewTestHeader(HorizontalLine);
            ViewTestHeader("Test 7.\nCheck that constructors can't be given invalid values.");
            try
            { AlarmClock WrongTimeConstructor = new AlarmClock(24, 0); }
            catch (ArgumentException a)
            { ViewErrorMessage(a.Message); }
            try
            { AlarmClock WrongTimeConstructor = new AlarmClock(0, 61); }
            catch (ArgumentException a)
            { ViewErrorMessage(a.Message); }          
            //Samma test utav felaktiga värden som i test 6, men här skickas värden via konstruktorer
            // som i sin tur skickar värden till egenskaperna där undantag kastas.
        }
       private static void Run(AlarmClock ac, int minutes) //Skicka med objekt/referens samt antal minuter/ggr programmet ska köra ticktock.
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

       private static void ViewErrorMessage(string message) //Anropas för att skriva ut felmeddelande. Mainmetoden är för fint för sånt.
       {
           Console.BackgroundColor = ConsoleColor.DarkRed;
           Console.WriteLine(message);
           Console.ResetColor();
       }

       private static void ViewTestHeader(string header)
       {
           Console.WriteLine(header);
       } //anropas för att skriva ut meddelande.
    } 
}
