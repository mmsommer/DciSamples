using System;
using DciSampleWithExtensionMethods.Interactions.Roles;

namespace DciSampleWithExtensionMethods.Interactions.Traits
{
    static class AttackerTraits
    {
        public static int Attack(this AttackerRole attacker, DefenderRole defender)
        {
            var dice = new Dice();

            var damage = DetermineDamage(attacker, defender, dice);

            defender.Hitpoints -= damage;

            return damage;
        }

        public static int GetHits(this AttackerRole attacker, Dice dice)
        {
            var hits = 0;

            for (int i = 0; i < attacker.Power; i++)
            {
                var roll = dice.Roll();

                if (roll >= 7)
                {
                    hits++;
                }
            }

            return hits;
        }

        private static int DetermineDamage(AttackerRole attacker, DefenderRole defender, Dice dice)
        {
            var hits = attacker.GetHits(dice);

            var dodges = defender.GetDodges(dice);

            var damage = hits - dodges;

            return damage < 0 ? 0 : damage;
        }
    }
}
