using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //initial code for "regular" players
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            //creating smack-talkers and getting them in the game
            SmackTalkingPlayer smack = new SmackTalkingPlayer();
            smack.Name = "Jeff";
            smack.Taunt = "You most notable coward, you infinite and endless liar, you hourly promise-breaker, you owner of not one good quality!";
            smack.Play(player3);
            Console.WriteLine("-------------------");

            SmackTalkingPlayer smack2 = new SmackTalkingPlayer();
            smack2.Name = "Megan";
            smack2.Taunt = "I am sick when I do look on thee!";
            smack2.Play(player3);
            Console.WriteLine("-------------------");

            //creating onehigherroll
            OneHigherPlayer oneHigher = new OneHigherPlayer();
            oneHigher.Name = "Ryan";
            oneHigher.Play(smack2);
            Console.WriteLine("-------------------");

            //creating humanplayer
            HumanPlayer user = new HumanPlayer();
            Console.Write("What's your name?> ");
            user.Name = Console.ReadLine();
            user.Play(player1);
            Console.WriteLine("-------------------");





            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smack, smack2, oneHigher, user
            };
            //code for 4th and 5th rolls, with random pairs of opponents
            PlayMany(players);
        }
        //code to create the randomly generated games opponents
        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}