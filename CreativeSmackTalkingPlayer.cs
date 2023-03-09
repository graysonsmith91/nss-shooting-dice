using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public override int Roll()
        {
            List<string> insults = new List<string>() {
                "You have tiny stinky feet!",
                "Your music taste is subpar!",
                "You will never find true love!"
            };

            Random randomIndex = new Random();
            int r = randomIndex.Next(insults.Count);

            Console.WriteLine($"{Name}: {insults[r]}");
            return base.Roll();
        }
    }
}