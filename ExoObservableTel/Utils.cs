using System;
using System.Collections.Generic;
using System.Text;

namespace ExoObservableTel
{
    public static class Utils
    {
        public static Random Rng = new Random();

        public static int Roll()
        {
            return Rng.Next(0, 2);
        }

        public static int Roll(int n)
        {
            return Rng.Next(0, n + 1);
        }

        public static int SelectName()
        {
            return Rng.Next(0, 5);
        }
    }
}