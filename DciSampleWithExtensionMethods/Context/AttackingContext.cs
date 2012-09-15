namespace DciSampleWithExtensionMethods.Context
{
    using System;
    using DciSampleWithExtensionMethods.Interactions.Roles;
    using DciSampleWithExtensionMethods.Interactions.Traits;

    class AttackingContext
    {
        private Logger logger;

        private AttackerRole attacker;

        private DefenderRole defender;

        private AttackingContext(ConsoleColor color)
        {
            this.logger = new Logger { Color = color };
        }

        public static AttackingContext WithColor(ConsoleColor color)
        {
            return new AttackingContext(color);
        }

        public AttackingContext Attacker(AttackerRole attacker)
        {
            this.attacker = attacker;

            return this;
        }

        public void Attacks(DefenderRole defender)
        {
            this.defender = defender;
            DoIt();
        }

        private void DoIt()
        {
            if(!attacker.IsDead) // can't attack when you're dead...
            {
                if(defender.Dodge())
                {
                    logger.Log(string.Format("{0} dodges the attack of {1}", defender.Name, attacker.Name));
                }
                else
                {
                    var damage = attacker.Attack();

                    if(damage <= 0)
                    {
                        logger.Log(string.Format("{0} misses {1}!", attacker.Name, defender.Name));
                    }
                    else
                    {
                        var parry = defender.Parry();

                        if(parry > 0)
                        {
                            logger.Log(
                                string.Format(
                                    "{0} parries {1} of {2} points of the attack of {3}",
                                    defender.Name,
                                    parry,
                                    damage,
                                    attacker.Name));
                        }

                        damage -= parry;

                        if(damage > 0)
                        {
                            defender.Hitpoints -= damage;

                            logger.Log(string.Format("{0} does {1} damage to {2}", attacker.Name, damage, defender.Name));
                        }
                    }
                }

                logger.Log(string.Format("{0} has {1} hitpoints remaining", defender.Name, defender.Hitpoints));
            }

            if(defender.IsDead)
            {
                logger.Log(string.Format("{0} has died!", defender.Name));
            }
        }
    }
}
