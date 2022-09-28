//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Timers;

//namespace Tamagotchi
//{
//    internal class ToyArgs 
//    {

//        string title;
//        string text;
//        int icon;
//        static ToyArgs prevToyArgs = null;
//        static List<string> args = new List<string>() { "Хочу есть" , "Хочу спать", "Я заболел", "Хочу играть" , "Пошли гулять"};

//        ToyArgs(string title, string text, int icon)
//        {

//            this.title = title;
//            this.text = text;
//            this.icon = icon;

//        }

//        public static ToyArgs getMessageArgs()
//        {

//            ToyArgs toyArgs = null;

//            Random rand = new Random();
//            int i = rand.Next(0, 4);
//            switch (i)
//            {
//                case 0: IConvertible = 
//            }

//            toyArgs = new ToyArgs("Тамагочи", args[i]);
//        }
        
//    }
//}
