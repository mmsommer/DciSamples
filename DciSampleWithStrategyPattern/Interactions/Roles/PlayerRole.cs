namespace DciSampleWithStrategyPattern.Interactions.Roles
{
    interface PlayerRole
    {
        string Name { get; set; }

        int Hitpoints { get; set; }

        bool IsDead { get; }
    }
}
