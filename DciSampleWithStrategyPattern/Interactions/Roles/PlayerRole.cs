namespace DciSampleWithStrategyPattern.Interactions.Roles
{
    interface PlayerRole : HasTraits<PlayerRole>
    {
        string Name { get; set; }

        int Hitpoints { get; set; }

        bool IsDead { get; }
    }
}
