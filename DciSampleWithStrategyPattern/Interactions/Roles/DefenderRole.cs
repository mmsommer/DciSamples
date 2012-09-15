using DciSampleWithStrategyPattern.Interactions.Traits;

namespace DciSampleWithStrategyPattern.Interactions.Roles
{
    interface DefenderRole : PlayerRole
    {
        DefenderTraits DefenderTraits { get; set; }
    }
}
