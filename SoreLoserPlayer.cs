using System;

namespace ShootingDice
{

    // A Player that throws an exception when they lose to the other player
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            try
            {
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                    Console.WriteLine();
                }
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine($"{other.Name} Wins!");
                    Console.WriteLine();
                    throw new ArgumentException();
                }
                else
                {
                    Console.WriteLine("It's a tie");
                    Console.WriteLine();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{Name}: You cheated!!");
                Console.WriteLine();
            }
        }
    }
}