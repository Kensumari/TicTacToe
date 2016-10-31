using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class End
    {
        public bool gameOver = false;
        public void winCondition(List<int> l)
        {
            if (l.Contains(1) && l.Contains(2) && l.Contains(3) ||
                l.Contains(4) && l.Contains(5) && l.Contains(6) ||
                l.Contains(7) && l.Contains(8) && l.Contains(9) ||
                l.Contains(1) && l.Contains(5) && l.Contains(9) ||
                l.Contains(3) && l.Contains(5) && l.Contains(7))
            {
                gameOver = true;
            }
        }
        public void tieCondition(List<int> l)
        {
            if (l.Count == 9)
            {
                gameOver = true;
                Console.WriteLine("It was a tie, well fought!");
            }
        }
    }
}
