using System;

namespace ShootingDice
{

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {

        public override int Roll()
        {
            return new Random().Next(4, 7);
        }

        public override void Play(Player other)
        {
            int myRoll = Roll();
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