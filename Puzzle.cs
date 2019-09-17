/* Puzzle Class
 *  1. counts how many times a letter appears in the puzzle;
 *  2. determines if a player solves the puzzle
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Puzzle
    {
        private const string PUZZLE = "GAMEOFTHRONES";
        private int letterCounts;

        // Constructor
        public Puzzle()
        {
            letterCounts = 0;
        }

        // Count numbers of a letter in the puzzle
        public void CountLetter(string letter)
        {
            letterCounts = 0;
            foreach (char character in PUZZLE)
            {
                if (character.ToString() == letter)
                {
                    letterCounts += 1;
                }
            }
        }
        
        public int NumOfLetter
        {
            get { return letterCounts; }
        }

        // Determine if the player solve the puzzle
        // Static method: To call this method, using Puzzle.IsPuzzleSolved(string args)
        public static bool IsPuzzleSolved(string puz)
        {
            int spacePosition = puz.IndexOf(" ", 0);
            puz = puz.ToUpper().Trim();
            
            // Remove spaces from the puz user has entered
            while (spacePosition != -1)
            {
                puz = puz.Remove(spacePosition, 1);
                spacePosition = puz.IndexOf(" ", spacePosition + 1);
            }
           
            if (puz == PUZZLE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Return the origin puzzle
        // To call it, using Puzzle.OriginPuzzle
        public static string OriginPuzzle
        {
            get { return PUZZLE; }
        }
    }
}
