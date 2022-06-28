using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Moto : Zasib // мотоцикл
    {
        public Moto(double speed)
            : base(speed)
        {
            Speed = speed;
            Wheels = 2;
            Doors = "дверей немає";
        }
    }
}
