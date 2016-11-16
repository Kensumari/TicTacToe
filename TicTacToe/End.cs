using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class End
    {
        private string name1;
        private string name2;
        public bool SetPlayer { get; set; }
        public End(string name1,string name2)
        {
            this.name1 = name1;
            this.name2 = name2;
        }
        public bool GameOver = false;
        public void WinCondition(List<int> l)
        {
            if (l.Contains(1) && l.Contains(2) && l.Contains(3) ||
                l.Contains(4) && l.Contains(5) && l.Contains(6) ||
                l.Contains(7) && l.Contains(8) && l.Contains(9) ||
                l.Contains(1) && l.Contains(5) && l.Contains(9) ||
                l.Contains(3) && l.Contains(5) && l.Contains(7))
            {
                GameOver = true;
                if (SetPlayer == false)
                {
                    Console.WriteLine("Congratulations to " + name1);
                }
                if (SetPlayer == true)
                {
                    Console.WriteLine("Congratulations to " + name2);
                }
            }
        }
        public void TieCondition()
        {
                GameOver = true;
                Console.WriteLine("It was a tie, well fought!");
        }
    }
}
