using DciSampleWithStrategyPattern.Interactions.Roles;
using DciSampleWithStrategyPattern.Interactions.Traits;

namespace DciSampleWithStrategyPattern.Data
{
    class Player : AttackerRole, DefenderRole
    {
        private AttackerTraits attackerTraits;
        private DefenderTraits defenderTraits;

        public Player(AttackerTraits attackerTraits = null, DefenderTraits defenderTraits = null)
        {
            AttackerTraits = attackerTraits ?? new AttackerTraits();
            DefenderTraits = defenderTraits ?? new DefenderTraits();
        }

        public string Name { get; set; }

        public int Hitpoints { get; set; }

        public bool IsDead
        {
            get { return Hitpoints <= 0; }
        }

        public AttackerTraits AttackerTraits
        {
            get { return attackerTraits; }
            set { attackerTraits = value; }
        }

        public DefenderTraits DefenderTraits
        {
            get { return defenderTraits; }
            set { defenderTraits = value; }
        }
    }
}
