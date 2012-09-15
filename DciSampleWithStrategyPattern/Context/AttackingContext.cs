using DciSampleWithStrategyPattern.Interactions.Roles;
using DciSampleWithStrategyPattern.Interactions.Traits;
using System;

namespace DciSampleWithStrategyPattern.Context
{
    class AttackingContext
    {
        private Logger logger;

        private AttackerTrait attacker;

        private AttackingContext(ConsoleColor color)
        {
            this.logger = new Logger { Color = color };
        }

        public static AttackingContext WithColor(ConsoleColor color)
        {
            return new AttackingContext(color);
        }

        public AttackingContext Attacker(AttackerTrait attacker)
        {
            this.attacker = attacker;

            return this;
        }

        public void Attacks(DefenderTrait defender)
        {
            if (!attacker.Role.IsDead) // can't attack when you're dead...
            {
                var damage = this.attacker.Execute(defender);

                if (damage > 0)
                {
                    logger.Log(string.Format("{0} does {1} damage to {2}", attacker.Role.Name, damage, defender.Role.Name));
                }
                else
                {
                    logger.Log(string.Format("{0} misses {1}!", attacker.Role.Name, defender.Role.Name));
                }

                logger.Log(string.Format("{0} has {1} hitpoints remaining", defender.Role.Name, defender.Role.Hitpoints));
            }

            if (defender.Role.IsDead)
            {
                logger.Log(string.Format("{0} has died!", defender.Role.Name));
            }
        }
    }
}
