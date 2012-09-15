using DciSampleWithExtensionMethods.Interactions.Roles;

namespace DciSampleWithExtensionMethods.Interactions.Traits
{
    static class DefenderTraits
    {
        public static int GetDodges(this DefenderRole defender, Dice dice)
        {
            var dodges = 0;

            for (int i = 0; i < defender.Agility; i++)
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
