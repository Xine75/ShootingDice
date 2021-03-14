using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            //Call roll for "this" object and "other" object
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1;

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            Console.WriteLine($"{Name} wins!");
        }

    }
}
