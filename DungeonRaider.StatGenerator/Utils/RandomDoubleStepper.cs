using System;

namespace DungeonRaider.StatGenerator.Utils
{
    public static class RandomDoubleStepper
    {
        public static Random Random { get; private set; } = new Random();

        public static double NextDoubleBeetween(double from, double to, int digits)
        {
            double preValue = Random.NextDouble() * (to - from) + from;
            return Math.Round(preValue, digits);
        }

    }
}

