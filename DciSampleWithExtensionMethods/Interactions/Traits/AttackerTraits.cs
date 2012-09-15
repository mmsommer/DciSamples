using DciSampleWithExtensionMethods.Interactions.Roles;
using DciSampleWithExtensionMethods.Data;
using System;

namespace DciSampleWithExtensionMethods.Interactions.Traits
{
    static class AttackerTraits
    {
        public static int Attack(this AttackerRole attacker)
        {
            var dice = new Dice();

            var damageDealt = attacker.DetermineDamage();

            var damage = attacker.Hits(dice) ? damageDealt : 0;

            return damage < 0 ? 0 : damage;
        }

        private static bool Hits(this AttackerRole attacker, Dice dice)
        {
            var hits = 0;

            for(int i = 0; i < attacker.Power; i++)
            {
                var roll = dice.Roll();

                if(roll >= 7)
                {
                    hits++;
                }
            }

            return hits > 0;
        }

        public static int DetermineDamage(this AttackerRole attacker)
        {
            var dice = new Dice();

            var abilityBonus = attacker.Power - attacker.Weapon.PowerNeeded;

            var possibleDamage = attacker.Weapon.DamageBonus + abilityBonus;
            possibleDamage = possibleDamage <= 0 ? 0 : possibleDamage;

            var successRate = dice.Roll() / 10.0;

            return (int)Math.Round(possibleDamage * successRate);
        }
    }
}
