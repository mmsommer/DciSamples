using DciSampleWithStrategyPattern.Interactions.Roles;
using DciSampleWithStrategyPattern.Interactions.Traits;
using System;
using System.Collections.Generic;

namespace DciSampleWithStrategyPattern.Data
{
    class Player : PlayerRole
    {
        private Dictionary<string, TraitOf<PlayerRole>> traits;

        public Player()
        {
            traits = new Dictionary<string, TraitOf<PlayerRole>>();
        }

        public string Name { get; set; }

        public int Hitpoints { get; set; }

        public bool IsDead
        {
            get { return Hitpoints <= 0; }
        }

        public void AddTrait(TraitOf<PlayerRole> trait)
        {
            var traitName = trait.GetType().Name;

            trait.Role = this;

            if (!traits.ContainsKey(traitName))
            {
                traits.Add(traitName, trait);
            }
            else
            {
                traits[traitName] = trait;
            }
        }

        public U Get<U>() where U : TraitOf<PlayerRole>
        {
            var traitName = typeof(U).Name;

            if (!traits.ContainsKey(traitName))
            {
                throw new ArgumentOutOfRangeException("This object doesn't have a trait named '" + traitName + "'");
            }

            return traits[traitName] as U;
        }
    }
}
