using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа перевода данных угла из градусов в радианы.");
            Console.Write("Введите значение градусов: ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение минут: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение секунд: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus, min, sec);
            angle.AngleOut();
            angle.Radians();

            Console.ReadKey();
        }
    }
    class Angle
    {
        private int gradus;
        private int min;
        private int sec;
        public int Gradus
        {
            set
            {
                if (value >= 0 && value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение градусов введено неверно");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение минут введено неверно");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение секунд введено неверно");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;

        }
        public void AngleOut()
        {
            Console.WriteLine($"Значения угла: {Gradus} (град): {Min} (мин): {Sec} (сек)");

        }
        public void Radians()
        {
            double Rad = ((Gradus * Math.PI) / 180) + ((Min * Math.PI) / (60 * 180)) + ((Sec * Math.PI) / (180 * 3600));
            Console.WriteLine($"Значения угла в радианах: {Rad:f2}");
        }




    }
}
