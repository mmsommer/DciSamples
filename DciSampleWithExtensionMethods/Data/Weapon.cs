
namespace DciSampleWithExtensionMethods.Data
{
    class Weapon
    {
        public string Name { get; set; }

        public int DamageBonus { get; set; }

        public int PowerNeeded { get; set; }

        public int ParryBonus { get; set; }

        public int AgilityNeeded { get; set; }

        public static Weapon Longsword
        {
            get
            {
                return new Weapon {
                    DamageBonus = 4,
                    Name = "Longsword",
                    ParryBonus = 3,
                    PowerNeeded = 3,
                    AgilityNeeded = 3
                };
            }
        }

        public static Weapon Shortsword
        {
            get
            {
                return new Weapon {
                    DamageBonus = 2,
                    Name = "Shortsword",
                    ParryBonus = 4,
                    PowerNeeded = 2,
                    AgilityNeeded = 2
                };
            }
        }
    }
}
