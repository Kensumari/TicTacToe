using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        Player player = new Player();
        End end = new End();
        int j = 0;
        //setPlayer puts the player 1 = false and player 2 = true
        public bool setPlayer = false;
        public void initiateBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i);
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }
        public void runGame()
        {
            while (end.gameOver == false)
            {
                // switching between 
                if (j % 2 == 0)
                {
                    setPlayer = false;
                    player.P1();
                }
                else
                {
                    setPlayer = true;
                    player.P2();
                }

                //updating the board

                for (int i = 1; i < 10; i++)
                {

                    if (player.p1List.Contains(i))
                    {

                        Console.Write(player.p1sym);
                    }
                    else if (player.p2List.Contains(i))
                    {
                        Console.Write(player.p2sym);
                    }
                    else
                    {
                        Console.Write(i);
                    }
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("");
                    }
                }
                if (setPlayer == false)
                {
                    end.winCondition(player.p1List);
                }
                else
                {
                    end.winCondition(player.p2List);
                }
                end.tieCondition(player.totalList);
                j++;
            }            
        }
    }
}
