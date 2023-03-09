using System;

namespace ShootingDice
{
    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.WriteLine("Please enter a number:");
            int myRoll = int.Parse(Console.ReadLine());
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
                Console.WriteLine();
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("It's a tie");
                Console.WriteLine();
            }
        }
    }
}