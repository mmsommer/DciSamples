using DciSampleWithStrategyPattern.Interactions.Traits;

namespace DciSampleWithStrategyPattern.Interactions.Roles
{
    interface AttackerRole : PlayerRole
    {
        AttackerTraits AttackerTraits { get; set; }
    }
}
