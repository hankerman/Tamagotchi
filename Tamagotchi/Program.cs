using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Diagnostics;

namespace Tamagotchi
{
    internal class Program
    {

        private static Timer aTimer;


        static void Main(string[] args)
        {

            SetTimer();
            

            Console.WriteLine("\t # # # # # # # # ");
            Console.WriteLine("\t#               #");
            Console.WriteLine("\t#   ###    ###  #");
            Console.WriteLine("\t#  ##  #  ##  # #");
            Console.WriteLine("\t#  ##  #  ##  # #");
            Console.WriteLine("\t#  #   #  #   # #");
            Console.WriteLine("\t#   ###    ###  #");
            Console.WriteLine("\t#               #");
            Console.WriteLine("\t#          #    #");
            Console.WriteLine("\t#    ######     #");
            Console.WriteLine("\t#               #");
            Console.WriteLine("\t#               #");
            Console.WriteLine("\t # # # # # # # # ");
            Toy toy = new Toy();
            



        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new Timer(120000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            aTimer.Stop();
            aTimer.Dispose();
            MessageBox.Show("Время вышло", "Конец игры", MessageBoxButtons.OK);
            
        }
    }
}
