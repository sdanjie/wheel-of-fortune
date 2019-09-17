/* 
 * Form name: formGuessLetter
 * Class: frmGuess
 * On the interface of the form:
 * 1) Display available leters
 * 2) Display player name
 * 3) The player is asked for a letter
 * 
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
    public partial class frmGuess : Form
    {
        
        private string playerName;
        private string _availList;
        private string _letter;
        private int _numberOfLetter;

        public frmGuess(string str_player)
        {
            InitializeComponent();
            playerName = str_player;
        }

        private void frmGuess_Load(object sender, EventArgs e)
        {
            lblEnterHint.Text = playerName + "- Enter a letter";
            lblAvailLetters.Text = _availList;
        }

        // btnGuess_Click method
        private void btnGuess_Click(object sender, EventArgs e)
        {
            Puzzle checkLetter = new Puzzle();
            try
            {
                _letter = txtLetter.Text;
                if (IsLetterValid(_letter))
                {
                    checkLetter.CountLetter(_letter);
                    _numberOfLetter = checkLetter.NumOfLetter;
                    RemoveLetter();
                    if (_numberOfLetter != 0)
                    {                       
                        MessageBox.Show(_numberOfLetter + " " 
                                        + _letter + "s in the puzzle.");
                    }       
                    else
                    {
                        MessageBox.Show("Sorry, " + _letter + " is not in the puzzle.\n"
                                         + playerName + " lost your turn.");                   
                    }
                    // Close the form and go back to the mainform
                    this.Close();
                }
                else
                {
                    MessageBox.Show(_letter + " is not available.\n" +
                        "Choose another letter from list above.");
                    txtLetter.Clear();
                    btnGuess.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }   // end btnGuess Click method

        
        // Allow entering an alphabetic character only
        private void AlphabetsOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            { 
                e.Handled = true;
                MessageBox.Show("Enter letter only.");
            }
            else
            {
                btnGuess.Enabled = true;
            }
        }

        // Method: Determine if a letter is available in the remained letters
        private bool IsLetterValid (string str_letter)
        {
            if (_availList.Contains(str_letter) && str_letter != " ")
            {
                return true;
            }
            else
            {
                return false ;
            }
        }   // end IsLetterValid

        // Method: remove a letter from available letter list
        public void RemoveLetter()
        {
            int position = _availList.IndexOf(_letter);
            _availList = _availList.Remove(position, 1);
            _availList = _availList.Insert(position, " ");
            lblAvailLetters.Text = _availList;
        } // end RemoveLetter method

        // Set and get methods
        public string AvailLetters
        {
            set { _availList = value; }
            get { return _availList; }     
        }

        public string GetLetter
        {
            get { return _letter; }
        }

        public int GetNumberOfLetter
        {
            get { return _numberOfLetter; }
        }
    }   // end class
}   // end namespace
