using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BMW : ICar
    {
        public void Start()
        {
            Console.WriteLine("BMW is start");
        }
    }
}
