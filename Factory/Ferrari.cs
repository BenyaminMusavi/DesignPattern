using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Ferrari : ICar
    {
        public void Start()
        {
            Console.WriteLine("Ferrari is start");
        }
    }
}
