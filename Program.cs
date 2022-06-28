using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Zasib avto = new Avto(130);
            Zasib moto = new Moto(80);
            Zasib mop = new Mop(50);
            Zasib train = new Train(170);


            Inf newInf = new Inf();
            newInf.AddTransport(avto);
            newInf.AddTransport(moto);
            newInf.AddTransport(mop);
            newInf.AddTransport(train);


            newInf.OpenDoors(avto);
            newInf.OpenDoors(moto);
            newInf.OpenDoors(mop);
            newInf.OpenDoors(train);


            newInf.NumberOfWheels(avto);
            newInf.NumberOfWheels(moto);
            newInf.NumberOfWheels(mop);
            newInf.NumberOfWheels(train);

            if (newInf.OpenDoors(avto) || newInf.OpenDoors(train))
            {
                avto.Doors = "двері відчинено";
                train.Doors = "двері відчинено";
            }

            avto.Print();
            moto.Print();
            mop.Print();
            train.Print();
        }
    }
}
