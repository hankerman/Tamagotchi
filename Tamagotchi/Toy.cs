using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Tamagotchi
{
    internal class Toy
    {
        bool isAlife;
        int interest;
        ToyArgs prevArgs;
        Timer timer;        
        SortedDictionary<string, MessageBoxIcon> wishlist = new SortedDictionary<string, MessageBoxIcon>() { { "Хочу есть" , MessageBoxIcon.Warning},
            {"Хочу спать", MessageBoxIcon.Stop }, {"Я заболел", MessageBoxIcon.Warning}, {"Поиграешь со мной?", MessageBoxIcon.Question},
            {"Погуляешь со мной?", MessageBoxIcon.Question } };

        public Toy()
        {
            isAlife = true;
            prevArgs = null;
            initTimer();
            prevArgs = getWishlist();
            Ilive();
            interest = 0;
            
        }

        public void IsInteres()
        {
            
            if(interest == 3)
            {
                MessageBox.Show("Я все", prevArgs.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer.Stop();
                timer.Dispose();
                isAlife = false;
            }

            interest++;
            

        }



        private void initTimer()
        {
            timer = new Timer(2000);
            timer.Elapsed += OnToyEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

        }

        public void OnToyEvent(Object source, ElapsedEventArgs e)
        {

            timer.Enabled = false;

            ToyArgs toyArgs = getWishlist();
            while (prevArgs.text == toyArgs.text)
            {
                toyArgs = getWishlist();
            }
            prevArgs.text = toyArgs.text;
            DialogResult res = MessageBox.Show( toyArgs.text, toyArgs.title, MessageBoxButtons.YesNo, toyArgs.icon);
            //Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
            //                  e.SignalTime);
            if(res == DialogResult.Yes)
            {
                timer.Enabled = true;
            }
            else
            {
                //MessageBox.Show("Я все", toyArgs.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //timer.Stop();
                //timer.Dispose();
                //isAlife = false;

                IsInteres();
                timer.Enabled = true;

            }
        }


        

        public void Ilive()
        {

            while (isAlife)
            {

            }

        }

        private ToyArgs getWishlist()
        {
            ToyArgs toy = null;
            Random random = new Random();
            int temp = random.Next(0, 4);
            SortedDictionary<string, MessageBoxIcon>.KeyCollection key = wishlist.Keys;
            List<string> keyslist = key.ToList();
            //keyslist.ForEach(k => Console.WriteLine(k));
            MessageBoxIcon icon;
            wishlist.TryGetValue(keyslist[temp], out icon);
            toy = new ToyArgs("Барсик", keyslist[temp], icon);
            return toy;

        }


        private class ToyArgs
        {

            public string title;
            public string text;
            public MessageBoxIcon icon;
            
            public ToyArgs(string title, string text, MessageBoxIcon icon)
            {

                this.title = title;
                this.text = text;
                this.icon = icon;

            }

            


        }



    }
}
