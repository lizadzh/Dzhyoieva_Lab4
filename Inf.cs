using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Inf
    {
        List<Zasib> vehicles = new List<Zasib>();
        public void AddTransport(Zasib transport)
        {
            vehicles.Add(transport);
        }
        public bool OpenDoors(Zasib transport)
        {
            if (transport.DoorsOpen() == "дверей немає")
            {
                Console.WriteLine($"{transport} немає дверей");
                return false;
            }
            else
            {
                Console.WriteLine($"{transport} двері відчиняються");
                return true;
            }
        }
        public void NumberOfWheels(Zasib transport)
        {
            if (transport.GetNumberOfWheels() == 2)
            {
                Console.WriteLine($"{transport} має 2 колеса");
            }
            else if (transport.GetNumberOfWheels() == 4)
            {
                Console.WriteLine($"{transport} має 4 колеса");
            }
            else Console.WriteLine($"{transport} має 100 колес");
        }
    }
}
