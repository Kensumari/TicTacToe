using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        int input;

        public char p1sym = 'X';
        public char p2sym = 'O';
        public List<int> p1List = new List<int>();
        public List<int> p2List = new List<int>();
        public List<int> totalList = new List<int>();

        public void P1 ()
        {
            input = Int32.Parse(Console.ReadLine());
            p1List.Add(input);
            totalList.Add(input);
        }
        public void P2()
        {
            input = Int32.Parse(Console.ReadLine());
            p2List.Add(input);
            totalList.Add(input);
        }
    }
}
