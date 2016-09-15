using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_to_Code_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = null;
            Console.WriteLine("What kind of car do you want(Suzuki or Toyota)?");
            string car;
            car = Console.ReadLine();

            if(car.ToUpper() == "TOYOTA")
            {
                factory = new ToyotaFactory("Avalon", 45);
                CarAssembler toyotaCar = new CarAssembler();
                toyotaCar.AssembleCar(factory);
            }
            else
            {
                factory = new SuzukiFactory("X-90", 155);
                CarAssembler suzukiCar = new CarAssembler();
                suzukiCar.AssembleCar(factory);
            }

        }
    }
}
