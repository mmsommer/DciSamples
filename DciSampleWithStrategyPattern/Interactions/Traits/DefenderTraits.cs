
namespace DciSampleWithStrategyPattern.Interactions.Traits
{
    class DefenderTraits
    {
        public int Agility { get; set; }

        public int GetDodges(Dice dice)
        {
            var dodges = 0;

            for (int i = 0; i < this.Agility; i++)
            {
                var roll = dice.Roll();

                if (roll >= 7)
                {
                    dodges++;
                }
            }

            return dodges;
        }
    }
}
