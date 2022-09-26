using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Tamagotchi
{
    internal class Program
    {

        private static Timer aTimer;


        static void Main(string[] args)
        {
            
            DialogResult res = MessageBox.Show("Запуск таймера?",
                                   "Тамагочи", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Information,
                                   MessageBoxDefaultButton.Button1, 0);
            if(res == DialogResult.Yes)
            {
                SetTimer();
                Console.ReadLine();
                aTimer.Stop();
                aTimer.Dispose();
                
            }
            else { 
                Console.WriteLine("Вы не запустили таймер"); 
            }

        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }
    }
}
