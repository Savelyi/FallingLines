﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class MyRand
    {
        
            static Random rnd = new Random();
            public static int Next(int minValue, int maxValue)
            {
                return rnd.Next(minValue, maxValue);
            }
        
    }
}
