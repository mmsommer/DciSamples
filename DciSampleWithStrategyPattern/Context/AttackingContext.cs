using DciSampleWithStrategyPattern.Interactions.Roles;
using System;

namespace DciSampleWithStrategyPattern.Context
{
    class AttackingContext
    {
        private Logger logger;

        private AttackerRole attacker;
        private DefenderRole defender;

        public AttackingContext(AttackerRole attacker, DefenderRole defender, ConsoleColor color)
        {
            this.attacker = attacker;
            this.defender = defender;

            this.logger = new Logger { Color = color };
        }

        public void Attack()
        {
            if (!attacker.IsDead) // can't attack when you're dead...
            {
                var damage = this.attacker.AttackerTraits.Attack(defender);

                if (damage > 0)
                {
                    logger.Log(string.Format("{0} does {1} damage to {2}", attacker.Name, damage, defender.Name));
                }
                else
                {
                    logger.Log(string.Format("{0} misses {1}!", attacker.Name, defender.Name));
                }

                logger.Log(string.Format("{0} has {1} hitpoints remaining", defender.Name, defender.Hitpoints));
            }

            if (defender.IsDead)
            {
                logger.Log(string.Format("{0} has died!", defender.Name));
            }
        }
    }
}
