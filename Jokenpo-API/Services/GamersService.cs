using System;
using Jokenpo_API.Models;
using Jokenpo_API.Services.Interfaces;

namespace Jokenpo_API.Services
{
    public class GamersService: IGamersService
    {

        public string GamerState(string choiceOfUser)
        {
            string msg = string.Empty;

            // Random object.
            Random rnd = new Random();

            // We have three options in the game: rock, paper and scissors.
            string[] options = { "Rock", "Paper", "Scissors" };

            // The system chooses a value to play.
            int number = rnd.Next(options.Length);

            // Choise of app.
            string choiceOfApp = options[number];

            // Validations for user victory.
            if (
                (choiceOfUser == Choices.Rock.ToString() && choiceOfApp == Choices.Scissors.ToString()) ||
                (choiceOfUser == Choices.Scissors.ToString() && choiceOfApp == Choices.Paper.ToString()) ||
                (choiceOfUser == Choices.Paper.ToString() && choiceOfApp == Choices.Rock.ToString())
               )
            {
                msg = string.Format("App choise {0}. Congratulations! You're the winner :)", choiceOfApp);
            }
            // validations for app victory.
            else if (
                (choiceOfApp == Choices.Rock.ToString() && choiceOfUser == Choices.Scissors.ToString()) ||
                (choiceOfApp == Choices.Scissors.ToString() && choiceOfUser == Choices.Paper.ToString()) ||
                (choiceOfApp == Choices.Paper.ToString() && choiceOfUser == Choices.Rock.ToString())
               )
            {
                msg = string.Format("App choise {0}. You are the loser :(", choiceOfApp);
            }
            // In case of a tie.
            else
            {
                msg = string.Format("App choise {0}. We tie ;)", choiceOfApp);
            }

            return msg;
        }
    }
}
