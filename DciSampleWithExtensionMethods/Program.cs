using System;
using System.Threading;
using DciSampleWithExtensionMethods.Context;
using DciSampleWithExtensionMethods.Data;
using DciSampleWithExtensionMethods.Interactions.Roles;

namespace DciSampleWithExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerRole player1 = new Player {
                Name = "Player 1",
                Hitpoints = 20,
                Power = 4,
                Agility = 3,
                Weapon = Weapon.Shortsword
            };

            PlayerRole player2 = new Player {
                Name = "Player 2",
                Hitpoints = 25,
                Power = 5,
                Agility = 1,
                Weapon = Weapon.Longsword
            };

            while(!player1.IsDead && !player2.IsDead)
            {
                AttackingContext
                    .WithColor(ConsoleColor.Green)
                    .Attacker(player1 as AttackerRole)
                    .Attacks(player2 as DefenderRole);

                Thread.Sleep(TimeSpan.FromSeconds(0.1));

                AttackingContext
                    .WithColor(ConsoleColor.Red)
                    .Attacker(player2 as AttackerRole)
                    .Attacks(player1 as DefenderRole);

                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
