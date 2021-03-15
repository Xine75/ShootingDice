using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // //initial code for "regular" players
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            Player player3 = new Player();
            player3.Name = "Wilma";

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            //creating smack-talker
            SmackTalkingPlayer smack2 = new SmackTalkingPlayer();
            smack2.Name = "Megan";
            smack2.Taunt = "I am sick when I do look on thee!";

            //creating onehigherroll player
            OneHigherPlayer oneHigher = new OneHigherPlayer();
            oneHigher.Name = "Ryan";

            //creating humanplayer and getting their name input
            HumanPlayer user = new HumanPlayer();
            Console.WriteLine("What's your name?> ");
            user.Name = Console.ReadLine();

            //creating creative smack-talker
            CreativeSmackTalkingPlayer randomInsulter = new CreativeSmackTalkingPlayer();
            randomInsulter.Name = "Shakespeare";

            //creating sore loser 
            SoreLoserPlayer brat = new SoreLoserPlayer();
            brat.Name = "Bratty Betty";

            //creating UpperHalfPlayer
            UpperHalfPlayer high = new UpperHalfPlayer();
            high.Name = "Rigged Ronnie";




            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smack2, oneHigher, user, randomInsulter, brat, high
            };
            //code for rest of rolls, with random pairs of opponents
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
                //player1.Play(player2);
                try
                {
                    player1.Play(player2);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bratty Betty says: Ugh I hate this game!");
                    continue;
                }
            }
        }
    }
}