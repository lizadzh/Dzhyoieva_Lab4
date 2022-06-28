using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Avto : Zasib // автомобіль
    {
        public Avto(double speed)
            : base(speed)
        {
            Speed = speed;
            Wheels = 4;
            Doors = "двері зачинено";
        }
    }
}
