using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Train : Zasib // потяг
    {
        public Train(double speed)
            : base(speed)
        {
            Speed = speed;
            Wheels = 100;
            Doors = "двері відчинено";
        }
    }
}
