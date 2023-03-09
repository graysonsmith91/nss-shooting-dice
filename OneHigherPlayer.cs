using System;

namespace ShootingDice
{
    // Override the Play method to make a Player who always rolls one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1;

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
