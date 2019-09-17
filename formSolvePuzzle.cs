/* 
 * Form name: formSolvePuzzle
 * Class: frmSolve
 * This form prompts the player to enter the puzzle 
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
    public partial class frmSolve : Form
    {
        public frmSolve()
        {
            InitializeComponent();
        }

        // btnCheck_Click method
        private void btnCheck_Click(object sender, EventArgs e)
        {
           try
            {
                if (txtEnterPuzzle.Text == "") 
                {
                    MessageBox.Show("You did not enter a puzzle.");
                }
                else 
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }              
        }   // end btnCheck_Click

        // KeyPress validation for txtEnterPuzzle control
        private void AlphabetsAndSpaceOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)
                && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Letter or space only.");
            }
            else
            {
                btnCheck.Enabled = true;
            }
        } // end KeyPress Validation

        public string GetPuzzle
        {
           get { return txtEnterPuzzle.Text; }
        }
    }
}
