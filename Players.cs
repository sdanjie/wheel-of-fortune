/* Players class computes  who is the current player
 * The id of 0 represents the "Player 1" and so
 *  _id (player's id: 0, 1, or 2)
 *  _name (player's name: Player 1, Player 2, Player 3)
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Players
    {
        private int _id;
        private string _name;

        // Constructor
        public Players()
        {
            _id = 0;
            _name = "Player 1";
        }

        // The CurrentPlayer method will compute who is the current player
        public void NextPlayer(int counts)
        {
            int num = counts % 3;
            if (num == 0)
            {
                _id = 0;
                _name = "Player 1";
            }
            else if (num == 1)
            {
                _id = 1;
                _name = "Player 2";
            }
            else
            {
                _id = 2;
                _name = "Player 3";
            }
        }   // end CurrentPlayer method

        // Return player id
        public int ID
        {
            get { return _id; }
        }

        // Return player name
        public string Name
        {
            get { return _name; }
        }
    }   // end class
}   // end namespace
