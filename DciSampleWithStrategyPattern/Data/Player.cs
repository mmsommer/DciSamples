using DciSampleWithStrategyPattern.Interactions.Roles;
using DciSampleWithStrategyPattern.Interactions.Traits;
using System;
using System.Collections.Generic;

namespace DciSampleWithStrategyPattern.Data
{
    class Player : PlayerRole, HasRoles
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

        public void AddRole(string roleName, TraitOf<PlayerRole> trait)
        {
            if (!traits.ContainsKey(roleName))
            {
                traits.Add(roleName, trait);
            }
            else
            {
                traits[roleName] = trait;
            }
        }

        public TraitOf<PlayerRole> AsRole(string roleName)
        {
            if (!traits.ContainsKey(roleName))
            {
                throw new ArgumentOutOfRangeException("This object doesn't have a role named '" + roleName + "'");
            }

            return traits[roleName];
        }
    }
}
