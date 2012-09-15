using DciSampleWithStrategyPattern.Interactions.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DciSampleWithStrategyPattern.Interactions.Traits
{
    abstract class TraitOf<T> where T : PlayerRole
    {
        public T Role { get; set; }

        public abstract int Execute(params TraitOf<T>[] traits);
    }
}
