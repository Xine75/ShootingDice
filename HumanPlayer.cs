using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write($"Hello {Name}! What's your roll?\n(1-15)> ");
            int myRoll = int.Parse(Console.ReadLine());
            return myRoll;
        }

    }
}
