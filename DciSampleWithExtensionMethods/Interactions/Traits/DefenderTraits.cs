using DciSampleWithExtensionMethods.Interactions.Roles;

namespace DciSampleWithExtensionMethods.Interactions.Traits
{
    internal static class DefenderTraits
    {
        public static int Parry(this DefenderRole defender)
        {
            var dice = new Dice();

            var weapon = defender.Weapon;

            var abilityBonus = defender.Agility - weapon.AgilityNeeded;

            var possibleParry = weapon.ParryBonus + abilityBonus;
            possibleParry = possibleParry <= 0 ? 0 : possibleParry;

            return dice.Roll() >= 6 ? possibleParry : 0;
        }

        public static bool Dodge(this DefenderRole defender)
        {
            var dice = new Dice();

            var dodges = 0;

            for(int i = 0; i < defender.Agility; i++)
            {
                var roll = dice.Roll();

                if(roll >= 7)
                {
                    dodges++;
                }
            }

            return dodges > 0;
        }
    }
}
