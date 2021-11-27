using System;
using System.Collections.Generic;

namespace laboratorna3OOP
{
    public class TPair
    {
        public double firstValue { get; set; }
        public double secondValue { get; set; }

        public TPair(double firstValue, double secondValue)
        {
            firstValue = this.firstValue;
            secondValue = this.secondValue;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Перше число: " + firstValue + "\n" + "Друге число: " + secondValue + "\n");
        }
        public string GetInfo()
        {
            return $"Перше число: {firstValue}\nДруге число: {secondValue}\n";
        }
        public static void plusOneToPair(ref double firstValue)
        {
            firstValue++;
            //secondValue++;
            
        }
        /*public static TPair  operator ++(TPair p)
        {
            p.firstValue++;
            p.secondValue++;
            return p;
        }*/

        public double minusToPair()
        {
            return firstValue--;
        }
        

    }
    class TTime :TPair
    {
        public int hour { get; set; }
        public int minute { get; set; }

        public TTime(double firstValue, double secondValue, int hour, int minute)
            : base(firstValue, secondValue)
        {
            hour = this.hour;
            minute = this.minute;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Перше число: " + firstValue + "\n" + "Друге число: " + secondValue + "\n" + "Годин: " + hour + "\n"+ "Хвилин: " + minute + "\n");
        }
        public string GetInfo()
        {
            return $"Перше число: {firstValue}\nДруге число: {secondValue}\nГодин: {hour} \n Хвилин: {minute}\n";
        }

    }
    class TMoney : TPair
    {
        public int hryvnia { get; set; }
        public int coin { get; set; }

        public TMoney(double firstValue, double secondValue, int hryvnia, int coin)
            : base(firstValue, secondValue)
        {
            hryvnia = this.hryvnia;
            coin = this.coin;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Перше число: " + firstValue + "\n" + "Друге число: " + secondValue + "\n" + "Гривень: " + hryvnia + "\n" + "Копійок: " + coin + "\n");
        }
        public string GetInfo()
        {
            return $"Перше число: {firstValue}\nДруге число: {secondValue}\nГривень: {hryvnia}\n Копійок: {coin}\n";
        }
    }
    class MainClass
    {
        
        static List<TPair> worker = new List<TPair>();
        static void Test()
        {
            Random rnd = new Random();
            TPair pair = new TPair(rnd.Next(10), rnd.Next(10));
            TTime time = new TTime(rnd.Next(10), rnd.Next(10), rnd.Next(24), rnd.Next(60));
            TMoney money = new TMoney(rnd.Next(10), rnd.Next(10), rnd.Next(50000), rnd.Next(100));
            worker.Add(pair);
            worker.Add(time);
            worker.Add(money);
        }
        static void ShowAll()
        {
            //Console.Clear();
            foreach (var item in worker)
            {
                if (item.GetType().Name.Equals("TPair"))
                {
                    Console.WriteLine((item as TPair).GetInfo() + "\n");
                }

                else if (item.GetType().Name.Equals("TTime"))
                {
                    Console.WriteLine((item as TTime).GetInfo() + "\n");
                }

                else if (item.GetType().Name.Equals("TMoney"))
                {
                    Console.WriteLine((item as TMoney).GetInfo() + "\n");
                }
            }
            Console.ReadKey();
            //Console.Clear();
        }
        public static void Main(string[] args)
        {

            Test();
            /*foreach (TPair p in worker)
                p.ShowInfo();
            Console.ReadKey();*/
            ShowAll();
        }
    }
}
