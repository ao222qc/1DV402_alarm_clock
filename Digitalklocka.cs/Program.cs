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
            AlarmClock test1 = new AlarmClock();

            Console.WriteLine("Test 1.");
            Console.WriteLine("Test of standard ctor.");
            Console.WriteLine(test1.ToString()); //anropar ToString som skriver ut det som genereras när objektet initieras.
            Console.WriteLine("\n");

            AlarmClock test2 = new AlarmClock(9, 42);
            Console.WriteLine("Test 2.");
            Console.WriteLine("Test of constructor with two parameters.");
            Console.WriteLine(test2.ToString());
            Console.WriteLine("\n");


            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("Test 3.");
            Console.WriteLine("Test of constructor with four parameters.");
            Console.WriteLine(test3.ToString());
            Console.WriteLine("\n");

            AlarmClock test4 = new AlarmClock(23, 58);
            Console.WriteLine("Test 4.");
            Console.WriteLine("Test of TickTock method.");
            for (int i = 0; i < 13; i++)
            {
                test4.TickTock();
                Console.WriteLine(test4.ToString()); //Anropa och skriv ut resultat ett visst antal gånger, bestäms utav forloopen.
            }
            Console.WriteLine("\n");

            AlarmClock test5 = new AlarmClock(6, 12, 6, 15);
            Console.WriteLine("Test 5.");
            Console.WriteLine("Test of TickTock and Alarm.");
            for (int j = 0; j < 6; j++)
            {
                if (test5.TickTock() == true) //Testar samt anropar TickTock i ett svep, när den returnerar true "går alarmet".
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0} BEEP BEEP BEEP! If you snooze you lose!", test5.ToString());
                    Console.ResetColor();
                }
                else
                { Console.WriteLine(test5.ToString()); } //Skriv ut resultat efter att TickTock anropas om den returnerar false (ej alarm)
            }
            Console.WriteLine("\n");

            

     


            //AlarmClock test6 = new AlarmClock(24, 61, 25, 70);
            //Console.WriteLine(test6.ToString());







            //for (int i = 0; i < 13; i++)
            //{
            //    Console.WriteLine(test.ToString());
            //    test1.TickTock();

            //}
            //Console.WriteLine(test.ToString());
            




            //for (int i = 0; i < 240; i++)
            //{
            //    Console.WriteLine(test.ToString());
            //    test.TickTock();
                

                //if (test.TickTock() == true)
                //{
                //    Console.BackgroundColor = ConsoleColor.Blue;
                //    Console.Write(test.ToString());
                //    Console.WriteLine("    BEEP BEEP BEEP!!");
                //    Console.ResetColor();
                //}
              

            //}

            
            
            
            

           
            
        }
    }
}
