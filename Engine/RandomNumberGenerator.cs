using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        //Creating a Random obj (_generator) and use the Next() method to get a 
        //random value between min and max values pass in as a parameter.
        private static Random _generator = new Random();

        public static int NumberBetween(int minVal, int maxVal) 
        { 
            return _generator.Next(minVal, maxVal + 1);
        }
    }
}
