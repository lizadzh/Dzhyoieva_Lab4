using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Zasib : IntZasib // транспортний засіб
    {
        protected double Speed { get; set; }
        protected int Wheels { get; set; }
        public string Doors { get; set; }
        public Zasib(double speed)
        {
            Speed = speed;
        }
        public string DoorsOpen() => Doors;
        public double GetSpeed() => Speed;
        public int GetNumberOfWheels() => Wheels;
        public void Print()
        {
            Console.WriteLine($"Транспорт: {GetType().Name}");
            Console.WriteLine($"Швидкість: {GetSpeed()}");
            Console.WriteLine($"Двері:  {DoorsOpen()}");
            Console.WriteLine($"Кількість колес: {GetNumberOfWheels()}");
        }
    }
}
