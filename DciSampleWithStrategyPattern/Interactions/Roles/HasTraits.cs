using DciSampleWithStrategyPattern.Interactions.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DciSampleWithStrategyPattern.Interactions.Roles
{
    interface HasTraits<T> where T : PlayerRole
    {
        void AddTrait(TraitOf<T> trait);

        U Get<U>() where U : TraitOf<T>;
    }
}
