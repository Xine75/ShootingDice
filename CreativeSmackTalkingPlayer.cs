using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Insults { get; set; } = new List<string>()
        {
            "I must tell you in your ear, sell when you can, you are not for all markets.",
            "I'd beat thee, but I would infect my hands.",
            "I scorn you, scurvy companion.",
            "More of your conversation would infect my brain.",
            "The tartness of your face sours ripe grapes.",
            "Thine face is not worth sunburning.",
            "Thou art a boil, a plague sore."
        };

        public override void Play(Player other)
        {
            base.Play(other);

            int x = new Random().Next(7);
            Console.Write($"{Name} says: ");
            Console.WriteLine(Insults[x]);
        }

    }
}