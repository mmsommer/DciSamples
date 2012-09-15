using DciSampleWithStrategyPattern.Interactions.Roles;

namespace DciSampleWithStrategyPattern.Interactions.Traits
{
    class AttackerTraits : TraitOf<PlayerRole>
    {
        public int Power { get; set; }

        private int DetermineDamage(DefenderTraits defender)
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
            var defender = traits[0] as DefenderTraits;

            var damage = DetermineDamage(defender);

            defender.Role.Hitpoints -= damage;

            return damage;
        }
    }
}
