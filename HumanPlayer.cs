using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.WriteLine("What's your name?> ");
            string userName = Console.ReadLine();
            Console.Write($"Hello {userName}! What's your roll?\n(1-15)> ");
            string humanRoll = Console.ReadLine();
            int humanRollInt = int.Parse(humanRoll);
            int otherRoll = other.Roll();

            Console.WriteLine($"{userName} rolls a {humanRollInt}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (humanRollInt > otherRoll)
            {
                Console.WriteLine($"{userName} Wins!");
            }
            else if (humanRollInt < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }

        }
    }
}