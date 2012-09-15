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
            player1.AddTrait(new AttackerTrait { Power = 8});
            player1.AddTrait(new DefenderTrait { Agility = 4 });

            var player2 = new Player()
            {
                Name = "Player 2",
                Hitpoints = 25
            };
            player2.AddTrait(new AttackerTrait { Power = 10 });
            player2.AddTrait(new DefenderTrait { Agility = 2 });

            while (!player1.IsDead && !player2.IsDead)
            {
                AttackingContext
                    .WithColor(ConsoleColor.Green)
                    .Attacker(player1.Get<AttackerTrait>())
                    .Attacks(player2.Get<DefenderTrait>());

                Thread.Sleep(TimeSpan.FromSeconds(0.1));

                AttackingContext
                    .WithColor(ConsoleColor.Red)
                    .Attacker(player2.Get<AttackerTrait>())
                    .Attacks(player1.Get<DefenderTrait>());

                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
