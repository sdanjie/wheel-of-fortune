/* Wheel class simulates spinning a wheel.
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Wheel
    {
        private int dollar;

        public Wheel()
        {
            dollar = 0;
        }

        // The spin method simulates the process of spinning a wheel
        public void Spin()
        {
            Random rand = new Random();
            int numberOnWheel = rand.Next(10) + 1;
            if (numberOnWheel == 1) { dollar = 100; }
            else if (numberOnWheel == 2) { dollar = 300; }
            else if (numberOnWheel == 3) { dollar = 500; }
            else if (numberOnWheel == 4) { dollar = 700; }
            else if (numberOnWheel == 5) { dollar = 900; }
            else if (numberOnWheel == 6) { dollar = 2000; }
            else if (numberOnWheel == 7) { dollar = 3000; }
            else if (numberOnWheel == 8) { dollar = 5000; }
            else if (numberOnWheel == 9) { dollar = -1000; }
            else { dollar = 0; }
        }

        // Return the value of the dollar field
        public int GetValue
        {
            get { return dollar; }
        }
    }
}
