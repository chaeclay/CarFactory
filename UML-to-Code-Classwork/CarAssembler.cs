using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_to_Code_Classwork
{
    class CarAssembler
    {
        public void AssembleCar(CarFactory factory)
        {
            Car car = factory.getCar();
            Console.WriteLine(car.getCompany());
            Console.WriteLine(car.getModel());
            Console.WriteLine(car.getSpeed());
            Console.Read();
        }
    }
}
