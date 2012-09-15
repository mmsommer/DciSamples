using System;
using DciSampleWithExtensionMethods.Context;
using DciSampleWithExtensionMethods.Data;
using DciSampleWithExtensionMethods.Interactions.Roles;
using System.Threading;

namespace DciSampleWithExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerRole player1 = new Player
            {
                Name = "Player 1",
                Hitpoints = 20,
                Power = 4,
                Agility = 3
            };

            PlayerRole player2 = new Player
            {
                Name = "Player 2",
                Hitpoints = 25,
                Power = 5,
                Agility = 1
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
