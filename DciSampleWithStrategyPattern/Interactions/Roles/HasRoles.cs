using DciSampleWithStrategyPattern.Interactions.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DciSampleWithStrategyPattern.Interactions.Roles
{
    interface HasRoles
    {
        void AddRole(string roleName, TraitOf<PlayerRole> trait);

        TraitOf<PlayerRole> AsRole(string roleName);
    }
}
