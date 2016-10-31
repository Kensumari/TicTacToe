using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        private string name1;
        private string name2;


       
        static void Main(string[] args)
        {
            var set = new Board();
            var program = new Program();
            Console.WriteLine("Welcome to TicTacToe, Please type in the 2 following players names.");
            program.name1 = Console.ReadLine();
            program.name2 = Console.ReadLine();
            Console.WriteLine("Player 1's name is " + program.name1);
            Console.WriteLine("Player 2's name is " + program.name2);
            Console.WriteLine("Thank you, I will now instruct you how to play the game");
            set.initiateBoard();
            Console.WriteLine("You can only type in between number 1-9 as you see on the screen, may the best player win");
            set.runGame();
            if (set.setPlayer == false)
            {
                Console.WriteLine("Congratulations to " + program.name1);
            }
            if (set.setPlayer == true)
            {
                Console.WriteLine("Congratulations to " + program.name2);
            }
            Console.ReadLine();
        }

        public string Human1
        {
            get
            {
                return name1;          
            }
        }

        public string Human2
        {
            get
            {
                return name2;
            }
        }
    }
}
