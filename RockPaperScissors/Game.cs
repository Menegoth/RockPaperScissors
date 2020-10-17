using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors {
    class Game {

        /// <summary>
        /// Check who won.
        /// </summary>
        /// <param name="answer">Rock, Paper or Scissors</param>
        /// <returns>Status of game</returns>
        public char CheckAnswer(string answer) {

            //get answer from player
            int computerAnswer = ComputerAnswer();

            //rock = 1, paper = 2, scissors = 3
            switch (answer) {

                case "rock":
                    if (computerAnswer == 1) {
                        return 't';
                    }
                    else if (computerAnswer == 2) {
                        return 'l';
                    }
                    else {
                        return 'w';
                    }

                case "paper":
                    if (computerAnswer == 1) {
                        return 'w';
                    }
                    else if (computerAnswer == 2) {
                        return 't';
                    }
                    else {
                        return 'l';
                    }

                case "scissors":
                    if (computerAnswer == 1) {
                        return 'l';
                    }
                    else if (computerAnswer == 2) {
                        return 'w';
                    }
                    else {
                        return 't';
                    }

                default:
                    return 'n';

            }

        }

        /// <summary>
        /// generate computer answer
        /// </summary>
        /// <returns>computer's answer</returns>
        private int ComputerAnswer() {

            Random generator = new Random();
            return generator.Next(1, 4);

        }

    }
}
