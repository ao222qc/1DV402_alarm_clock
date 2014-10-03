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
            AlarmClock test = new AlarmClock();

            


            for (int i = 0; i < 240; i++)
            {
                Console.WriteLine(test.ToString());
                test.TickTock();
                

                //if (test.TickTock() == true)
                //{
                //    Console.BackgroundColor = ConsoleColor.Blue;
                //    Console.Write(test.ToString());
                //    Console.WriteLine("    BEEP BEEP BEEP!!");
                //    Console.ResetColor();
                //}
              

            }

            
            
            
            

           
            
        }
    }
}
