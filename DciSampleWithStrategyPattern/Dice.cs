using System;

namespace DciSampleWithStrategyPattern
{
    public class Dice
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public int Roll()
        {
            return random.Next(1, 11);
        }
    }
}
