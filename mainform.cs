/*
 * Danjie Song
 * Update: 12/12/2017
 * CSC153 C# Programming: Wheel of Fortune
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelOfFortune
{
    
    public partial class frmMain : Form
    {
        // Global fields      
        private int gameTurns = 0;      // To hold the number of turns of game
        private int dollarSpinned;      // To hold a dollar amount spinned from the wheel 
        private int[] playerAmount = { 0, 0, 0 };   // To hold three players rewards

        // Create an instance of Players class
        private Players player = new Players();    

        public frmMain()
        {
            InitializeComponent();
        }

        /* ---------- btnSolve_Click Method ---------- */
        private void btnSolve_Click(object sender, EventArgs e)
        {
            // Player will enter the puzzle in a second form
            frmSolve playerSolve = new frmSolve();
            playerSolve.ShowDialog();

            string playerPuzzle = playerSolve.GetPuzzle;
            if (Puzzle.IsPuzzleSolved(playerPuzzle))
            {
                MessageBox.Show("Congratulation!\n" +
                    player.Name + " solved the puzzle.\n" +
                    "You won $" + playerAmount[player.ID]);
                MessageBox.Show("Click OK to close the game. Bye!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry! You did not solve the puzzle.");
                PassGameToNext();
            }
        }   // end btnSolve_Click method

            
        /* ---------- btnSpin_Click Method ---------- */
        /*   Divide the game into two parts:
             Part 1: Player spins the wheel.
             Part 2: Player guesses a letter. */
        private void btnSpin_Click(object sender, EventArgs e)
        {
            /* ----- Game part 1: Spin the wheel ----- */
            // Create an instance of Wheel class
            Wheel spinWheel = new Wheel();

            spinWheel.Spin();
            dollarSpinned = spinWheel.GetValue;
            MessageBox.Show(player.Name + " landed on $" + dollarSpinned);

            if (dollarSpinned != -1000 && dollarSpinned != 0)
            {
                /* ----- Game part 2: Guess a letter ----- */
                GuessALetter();               
            }
            else
            {
                // the value of wheel lands on -1000 or 0
                MessageBox.Show(player.Name + " lost this turn.");
                DisplayReward();
                PassGameToNext();
            } 
        }   // end btnSpin_Click method

        // Method: player guesses a letter 
        public void GuessALetter()
        {            
            // The player will enter a letter in a second form.
            frmGuess playerGuess = new frmGuess(player.Name);
            playerGuess.AvailLetters = lblAvailableLetters.Text;
            playerGuess.ShowDialog();

            int letterCounts = playerGuess.GetNumberOfLetter;
            try
            {
                if (letterCounts != 0)
                {
                    // Player got correct letters
                    string letter = playerGuess.GetLetter;
                    DisplayLetterInBox(letter);
                    DisplayReward(letterCounts);
                    ShowResult();
                }
                else
                {
                    // Player got an incorrect letter, 
                    // and the game is passed to the next player.
                    PassGameToNext();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Display a new list of the remained letter
            lblAvailableLetters.Text = playerGuess.AvailLetters;
        }   // end Guess method
       
    
        // Method: Pass game to next player   
        public void PassGameToNext()
        {
            gameTurns++;
            player.NextPlayer(gameTurns);
            lblGameProcess.Text = player.Name + " - Spin or Solve";
        }   // end PassGameToNext method


        // Method: Display rewards when player lands on -1000 or 0 
        public void DisplayReward()
        {
            TextBox[] amountBoxes = { txtAmount1, txtAmount2, txtAmount3 };
            playerAmount[player.ID] += dollarSpinned;
            amountBoxes[player.ID].Text = playerAmount[player.ID].ToString();
        }   // end DisplayReward method


        // Method: Display rewards when the letter is correct       
        public void DisplayReward(int number)
        {
            TextBox[] amountBoxes = { txtAmount1, txtAmount2, txtAmount3 };   
            playerAmount[player.ID] += dollarSpinned * number;
            amountBoxes[player.ID].Text = playerAmount[player.ID].ToString();
        }   // end DisplayReward method


        // Method: Show correct letters on the form
        public void DisplayLetterInBox(string str_letter)
        {
            TextBox[] letterBoxes = {txt1, txt2, txt3, txt4, txt5, txt6, txt7,
                                       txt8, txt9, txt10, txt11, txt12, txt13};
            int position = Puzzle.OriginPuzzle.IndexOf(str_letter, 0);
            while (position != -1)
            {
                
                letterBoxes[position].BackColor = Color.LightCyan;
                letterBoxes[position].Text = str_letter;
                position = Puzzle.OriginPuzzle.IndexOf(str_letter, position + 1);
            }
        }   // end DisplayLetter method
            

        // Method: Show the result when players enters a correct letter
        public void ShowResult()
        {
            if (IsAllBoxFilled())
            {
                MessageBox.Show("Congratulation!\n" + player.Name +
                                " solved the puzzle.\n" +
                                "You won $" + playerAmount[player.ID]);
                MessageBox.Show("Click OK to close the game. Bye!");
                this.Close();
            }
            else
            {
                MessageBox.Show(player.Name + " continues your game.");
            }
        }

        // Method: Check if all letter boxes on the form are filled
        public bool IsAllBoxFilled()
        {
            TextBox [] letterBoxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7,
                                       txt8, txt9, txt10, txt11, txt12, txt13};
            int countFilledBoxes = 0;
            bool boxFilled = false;
            foreach (TextBox txt in letterBoxes)
            {
                if ( txt.Text != "")
                {
                    countFilledBoxes += 1;
                }
            }
            if ( countFilledBoxes == 13)    // the puzzle has 13 letters
            {
                boxFilled = true;
            }
            return boxFilled;
        }   // end IsAllBoxFilled

    }   // end class
}   // end namespace
