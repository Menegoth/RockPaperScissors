using System;

namespace RockPaperScissors {
    class Program {
        static void Main(string[] args) {

            //create game
            Game game = new Game();
            int gamesPlayed = 0;
            int computerWins = 0;
            int playerWins = 0;

            // check who won and add to counter
            do {

                Console.WriteLine("Choose Rock, Paper or Scissors");
                string answer = Console.ReadLine().ToLower();

                char result = game.CheckAnswer(answer);

                switch (result) {

                    case 'w':
                        Console.WriteLine("You win.");
                        playerWins++;
                        break;

                    case 'l':
                        Console.WriteLine("You lose.");
                        computerWins++;
                        break;

                    case 't':
                        Console.WriteLine("You tied.");
                        break;

                    default:
                        Console.WriteLine("Command not recognized");
                        gamesPlayed--;
                        break;

                }

                gamesPlayed++;

            } while (gamesPlayed < 5);

            //shows wins and losses
            Console.WriteLine("\n\nPlayer Wins: " + playerWins + "\nComputer Wins: " + computerWins);

        }
    }
}
