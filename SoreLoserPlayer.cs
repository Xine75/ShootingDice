using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {


            int bratRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {bratRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (bratRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else
            {
                throw new Exception("Throws a Fit");
            }


        }




    }
}

