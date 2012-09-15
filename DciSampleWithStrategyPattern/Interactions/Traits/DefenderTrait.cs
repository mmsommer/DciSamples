using DciSampleWithStrategyPattern.Interactions.Roles;

namespace DciSampleWithStrategyPattern.Interactions.Traits
{
    class DefenderTrait : TraitOf<PlayerRole>
    {
        public int Agility { get; set; }

        public override int Execute(params TraitOf<PlayerRole>[] traits)
        {
            var dice = new Dice();

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
