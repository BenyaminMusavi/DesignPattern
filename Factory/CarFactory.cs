using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class CarFactory
    {
        public ICar GetCar(string type)
        {
            ICar car = null;
            if(type.ToLower() == "bmw")
            {
                return new BMW();
            }
            if (type.ToLower() == "benz")
            {
                return new Benz();
            }
            if (type.ToLower() == "ferrari")
            {
                return new Ferrari();
            }

            return null;
        }
    }
}
