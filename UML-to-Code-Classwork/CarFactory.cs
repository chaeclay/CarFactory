using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_to_Code_Classwork
{
    public abstract class CarFactory
    {
        public abstract Car getCar();
    }

    public class SuzukiFactory : CarFactory
    {
        string sModel;
        int sSpeed;

        public SuzukiFactory(string model, int speed)
        {
            sModel = model;
            sSpeed = speed;
        }
        
        public override Car getCar()
        {
            Suzuki newCar = new Suzuki();
            newCar.setSpeed(sSpeed);
            newCar.setModel(sModel);
            return newCar;
        }
    }

    public class ToyotaFactory : CarFactory
    {
        string tModel;
        int tSpeed;

        public ToyotaFactory(string model, int speed)
        {
            tModel = model;
            tSpeed = speed;
        }

        public override Car getCar()
        {
            Toyota newCar = new Toyota();
            newCar.setModel(tModel);
            newCar.setSpeed(tSpeed);
            return newCar;
        }

    }
}
