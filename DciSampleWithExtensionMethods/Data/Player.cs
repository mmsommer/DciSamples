using DciSampleWithExtensionMethods.Interactions.Roles;

namespace DciSampleWithExtensionMethods.Data
{
    class Player : AttackerRole, DefenderRole
    {
        public string Name { get; set; }

        public int Hitpoints { get; set; }

        public int Power { get; set; }

        public int Agility { get; set; }

        public bool IsDead
        {
            get { return Hitpoints <= 0; }
        }
    }
}
