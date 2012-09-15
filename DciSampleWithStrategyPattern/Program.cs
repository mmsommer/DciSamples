using System;
using DciSampleWithStrategyPattern.Context;
using DciSampleWithStrategyPattern.Data;
using DciSampleWithStrategyPattern.Interactions.Roles;
using DciSampleWithStrategyPattern.Interactions.Traits;
using System.Threading;

namespace DciSampleWithStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player()
            {
                Name = "Player 1",
                Hitpoints = 20
            };
            player1.AddRole("Attacker", new AttackerTraits { Power = 4, Role = player1 });
            player1.AddRole("Defender", new DefenderTraits { Agility = 3, Role = player1 });

            var player2 = new Player()
            {
                Name = "Player 2",
                Hitpoints = 25
            };
            player2.AddRole("Attacker", new AttackerTraits { Power = 5, Role = player2 });
            player2.AddRole("Defender", new DefenderTraits { Agility = 1, Role = player2 });

            while (!player1.IsDead && !player2.IsDead)
            {
                AttackingContext
                    .WithColor(ConsoleColor.Green)
                    .Attacker(player1.AsRole("Attacker"))
                    .Attacks(player2.AsRole("Defender"));

                Thread.Sleep(TimeSpan.FromSeconds(0.1));

                AttackingContext
                    .WithColor(ConsoleColor.Red)
                    .Attacker(player2.AsRole("Attacker"))
                    .Attacks(player1.AsRole("Defender"));

                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
