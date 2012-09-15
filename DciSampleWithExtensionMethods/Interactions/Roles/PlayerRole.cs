namespace DciSampleWithExtensionMethods.Interactions.Roles
{
    using DciSampleWithExtensionMethods.Data;

    internal interface PlayerRole
    {
        string Name { get; set; }

        Weapon Weapon { get; set; }

        bool IsDead { get; }
    }
}
