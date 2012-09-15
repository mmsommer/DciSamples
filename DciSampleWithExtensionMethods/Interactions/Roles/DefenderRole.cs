namespace DciSampleWithExtensionMethods.Interactions.Roles
{
    internal interface DefenderRole : PlayerRole
    {
        int Hitpoints { get; set; }

        int Agility { get; set; }
    }
}
