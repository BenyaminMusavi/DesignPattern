﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Benz : ICar
    {
        public void Start()
        {
            Console.WriteLine("Benz is start");
        }
    }
}
