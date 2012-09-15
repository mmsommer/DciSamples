namespace DciSampleWithExtensionMethods.Data
{
    using DciSampleWithExtensionMethods.Interactions.Roles;

    class Player : AttackerRole, DefenderRole
    {
        public string Name { get; set; }

        public int Hitpoints { get; set; }

        public int Power { get; set; }

        public int Agility { get; set; }

        public Weapon Weapon { get; set; }

        public bool IsDead
        {
            get { return Hitpoints <= 0; }
        }
    }
}
