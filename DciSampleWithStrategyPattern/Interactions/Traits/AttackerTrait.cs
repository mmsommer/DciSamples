using DciSampleWithStrategyPattern.Interactions.Roles;
using System;

namespace DciSampleWithStrategyPattern.Interactions.Traits
{
    class AttackerTrait : TraitOf<PlayerRole>
    {
        public int Power { get; set; }

        private int DetermineDamage(DefenderTrait defender)
        {
            var dice = new Dice();

            var hits = this.GetHits(dice);

            var dodges = defender.Execute();

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

        public override int Execute(params TraitOf<PlayerRole>[] traits)
        {
            if (traits.Length != 1)
            {
                throw new ArgumentOutOfRangeException("Expected exactly 1 trait, but got " + traits.Length);
            }
            else if (!(traits[0] is DefenderTrait))
            {
                throw new ArgumentOutOfRangeException("Parameter 0 is not a DefenderTrait");
            }

            var defender = traits[0] as DefenderTrait;

            var damage = DetermineDamage(defender);

            defender.Role.Hitpoints -= damage;

            return damage;
        }
    }
}
