using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_to_Code_Classwork
{
    public abstract class Car
    {
        public abstract string getCompany();
        public abstract string getModel();
        public abstract int getSpeed();
        public abstract void setModel(string model);
        public abstract void setSpeed(int speed);
    }
    public class Suzuki : Car
    {
        string company = "Suzuki";
        string sModel;
        int sSpeed;


        public override string getCompany()
        {
            return company;
        }

        public override string getModel()
        {
            return sModel;
        }

        public override int getSpeed()
        {
            return sSpeed;
        }

        public override void setModel(string model)
        {
            sModel = model;
        }

        public override void setSpeed(int speed)
        {
            sSpeed = speed;
        }

    }

    public class Toyota : Car
    {
        string company = "Toyota";
        string tModel;
        int tSpeed;

        public override string getCompany()
        {
            return company;
        }

        public override string getModel()
        {
            return tModel;
        }

        public override int getSpeed()
        {
            return tSpeed;
        }

        public override void setModel(string model)
        {
            tModel = model;
        }

        public override void setSpeed(int speed)
        {
            tSpeed = speed;
        }
    }
}
