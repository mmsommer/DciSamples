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
            var attackerTraits1 = new AttackerTraits
            {
                Power = 4
            };
            var defenderTraits1 = new DefenderTraits
            {
                Agility = 3
            };
            var player1 = new Player(attackerTraits1, defenderTraits1)
            {
                Name = "Player 1",
                Hitpoints = 20
            };

            var attackerTraits2 = new AttackerTraits
            {
                Power = 5
            };
            var defenderTraits2 = new DefenderTraits
            {
                Agility = 1
            };
            var player2 = new Player(attackerTraits2, defenderTraits2)
            {
                Name = "Player 2",
                Hitpoints = 25
            };

            var attackingContext1 = new AttackingContext(
                player1 as AttackerRole,
                player2 as DefenderRole,
                ConsoleColor.Green);
            var attackingContext2 = new AttackingContext(
                player2 as AttackerRole,
                player1 as DefenderRole,
                ConsoleColor.Red);

            while (!player1.IsDead && !player2.IsDead)
            {
                attackingContext1.Attack();

                Thread.Sleep(TimeSpan.FromSeconds(0.1));

                attackingContext2.Attack();

                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
