using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        public char P1sym = 'X';
        public char P2sym = 'O';
        Player player = new Player();
        End end;
        int j ;
        //setPlayer puts the player 1 = false and player 2 = true

        static string p1 = "Player 1";
        static string p2 = "Player 2";


        public Board(string name,string name2)
        {
            end = new End(name, name2);
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to TicTacToe, Please type in the 2 following players names.");
            p1 = Console.ReadLine();
            p2 = Console.ReadLine();
            var board = new Board(p1,p2);
            Console.WriteLine("Player 1's name is " + p1);
            Console.WriteLine("Player 2's name is " + p2);
            Console.WriteLine("Thank you, I will now instruct you how to play the game");
            board.initiateBoard();
            Console.WriteLine("You can only type in between number 1-9 as you see on the screen, may the best player win");
            board.runGame();

            Console.ReadLine();
        }

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
            while (end.GameOver == false)
            {
                // switching between 
                if (j % 2 == 0)
                {
                    end.SetPlayer = false;
                    player.P1();
                }
                else
                {
                    end.SetPlayer = true;
                    player.P2();
                }

                //updating the board

                for (int i = 1; i < 10; i++)
                {

                    if (player.P1List.Contains(i))
                    {

                        Console.Write(P1sym);
                    }
                    else if (player.P2List.Contains(i))
                    {
                        Console.Write(P2sym);
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
                if (end.SetPlayer == false)
                {
                    end.WinCondition(player.P1List);
                }
                else
                {
                    end.WinCondition(player.P2List);
                }
                j++;
                if (j == 9 && end.GameOver == false)
                {
                    end.TieCondition();
                }
            }            
        }
    }
}
