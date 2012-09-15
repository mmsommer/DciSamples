using DciSampleWithStrategyPattern.Interactions.Roles;

namespace DciSampleWithStrategyPattern.Interactions.Traits
{
    class AttackerTraits
    {
        public int Power { get; set; }

        public int Attack(DefenderRole defender)
        {
            var dice = new Dice();

            var damage = DetermineDamage(defender, dice);

            defender.Hitpoints -= damage;

            return damage;
        }

        private int DetermineDamage(DefenderRole defender, Dice dice)
        {
            var hits = this.GetHits(dice);

            var dodges = defender.DefenderTraits.GetDodges(dice);

            var damage = hits - dodges;

            return damage < 0 ? 0 : damage;
        }

        private int GetHits(Dice dice)
        {
            var hits = 0;

            for (int i = 0; i < this.Power; i++)
            {
                var roll = dice.Roll();

                if (roll >= 7)
                {
                    hits++;
                }
            }

            return hits;
        }
    }
}
