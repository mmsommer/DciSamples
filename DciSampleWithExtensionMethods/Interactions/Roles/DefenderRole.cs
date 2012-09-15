namespace DciSampleWithExtensionMethods.Interactions.Roles
{
    interface DefenderRole : PlayerRole
    {
        int Hitpoints { get; set; }

        int Agility { get; set; }
    }
}
